using FullApi.Models;

namespace FullApi.Routes
{
    public static class PessoaRoutes
    {
        public static List<Pessoa> Pessoas = new() 
        {
            new Pessoa(id : Guid.NewGuid(), nome : "Arthurito"),
            new Pessoa(id : Guid.NewGuid(), nome : "Pedro"),
            new Pessoa(id : Guid.NewGuid(), nome : "Cardoso")
            
        };

        public static void MapPessoaRotas(this WebApplication app)
        {
            app.MapGet(pattern: "/pessoa", handler: () => Pessoas);

            app.MapGet(pattern: "/pessoas/{nome}", 
                handler: (string nome) => Pessoas.Find(x => x.Nome.StartsWith(nome)));

            app.MapPost(pattern: "/pessoas", handler : (HttpContext request,Pessoa pessoa) =>
            {
                pessoa.Id = Guid.NewGuid();
                Pessoas.Add(pessoa);



                return Results.Ok(pessoa);
            });

            app.MapPut(pattern: "/pessoas/{id}", handler: (Guid id,Pessoa pessoa) =>
            {
                var encontrado = Pessoas.Find(x => x.Id == id);

                if (encontrado == null)
                {
                    return Results.NotFound();

                }

                encontrado.Nome = pessoa.Nome;

                return Results.Ok(encontrado);
            });

        }
              

        }
    }

