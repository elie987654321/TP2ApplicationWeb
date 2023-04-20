
namespace TP2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Dev.TestDeserializerUtilisateur();

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddSession();
            builder.Services.AddDistributedMemoryCache();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseSession();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

           


            app.MapControllerRoute(
                name: "Bienvenue",
                pattern: "Bienvenue",
                defaults: new {controller = "Home", action="Accueil" }
                );

            app.MapControllerRoute(
                name: "TousLesJeux",
                pattern: "TousLesJeux",
                defaults: new {controller = "Home", action="ListeDeJeux"}
                );

            app.MapControllerRoute(
                name: "VosFavoris",
                pattern: "VosFavoris",
                defaults: new {controller = "Home", action="Favoris" }
                );

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Connexion}/{action=Accueil}");
            
            app.Run();
        }
    }
}