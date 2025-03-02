
var builder = WebApplication.CreateBuilder(args); 
//  instance  of Iwebhost  ; contain kerstel server or iis


//manual additon of MVC from  aspcore.All
builder.Services.AddMvcCore(options =>
{


    options.MaxModelValidationErrors = 100;
}


);

// Add services to the container

builder.Services.AddControllersWithViews();

var app = builder.Build(); //  build the instance and call the server 









// Configure the HTTP request pipeline. 
if (!app.Environment.IsDevelopment()) //if env  is production 
{

    app.UseExceptionHandler("/Home/Error"); // this error pipeline  when there is 

    //incmming request but trigger error page whike outgoing
    // The default HSTS value is 30 days. 
    // You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.


app.UseStatusCodePages();
    app.UseHsts();
}
else // if the env is developement 
    app.UseDeveloperExceptionPage();//to get the exceptio n detail insight





app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=ManualModelOne}/{action=ManualView}/{id?}")


    .WithStaticAssets();


app.Run();


//manual instaantiation of mv fommicrosoft  aspnetcore.all  meta package to run on >net  framework
