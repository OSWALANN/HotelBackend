using System.Text.Json;

namespace WSTarjetaJuventud.Middlewares
{
	public class ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
	{
		private readonly RequestDelegate _next = next;
		private readonly ILogger<ExceptionHandlingMiddleware> _logger = logger;

		public async Task InvokeAsync(HttpContext context)
		{
			try
			{
				await _next(context);
			}
			catch (Exception ex)
			{
				var traceId = Guid.NewGuid().ToString();
				context.Response.Headers["trace-id"] = traceId;

				var (statusCode, title) = MapExceptionToStatus(ex);
				var response = new
				{
					Success = !(statusCode > 200),
					Message = title,
					StatusCode = statusCode,
				};

				_logger.LogError(ex, $"Error encontrado: TraceId: {traceId} Ruta: {context.Request.Path} Mensaje: {ex.Message}");

				context.Response.ContentType = "application/json";
				context.Response.StatusCode = statusCode;

				var json = JsonSerializer.Serialize(response);
				await context.Response.WriteAsync(json);
			}
		}

		private (int, string) MapExceptionToStatus(Exception ex)
		{
			return ex switch
			{
				UnauthorizedAccessException => (StatusCodes.Status401Unauthorized, "No autorizado."),
				KeyNotFoundException => (StatusCodes.Status404NotFound, "Recurso no encontrado."),
				ArgumentException => (StatusCodes.Status400BadRequest, "Datos no permitidos."),
				_ => (StatusCodes.Status500InternalServerError, "Error interno del servidor.")
			};
		}
	}
}