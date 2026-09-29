var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();


// Ideia 1 foi adicionar a tela login como a primeira tela a ser exibida quando o usuário acessar o sistema.
// mapcontrollerroute é usado para mapear rotas de controladores e ações no asp net core.
// ele define a rota padrão para o aplicativo. Então aqui nós declaramos que a tela Login será a primeira
// tela a ser exibida quando o usuário acessar o sistema.

// Ideia 2 foi manter a tela inicial como a primeira tela a ser exibida quando o usuário acessar o sistema.
// Mas parando pra pensar, a tela de inicial continua sendo a tela principal do sistema, então para o usuário acessar ela, ele tem que estár logado.
// Então vamo adicionar a autenticação, para que o usuário só consiga acessar a tela inicial ou qualquer outra tela depois de logar no sistema.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
