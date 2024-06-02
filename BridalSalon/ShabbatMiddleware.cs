namespace BridalSalon
{
    public class ShabbatMiddleware
    {
        private readonly RequestDelegate _next;
        public ShabbatMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            if(DateTime.Today.DayOfWeek.ToString()== "Saturday")
            {
                await context.Response.WriteAsync(new HttpResponseMessage
                {
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    Content = new StringContent("The service is not active!!")
                }.ToString());
            }
            else
                await _next(context);           
        }
    }
}
