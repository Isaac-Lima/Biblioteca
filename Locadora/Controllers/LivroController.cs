﻿using Locadora.Dto.Autor;
using Locadora.Dto.Livro;
using Locadora.Models;
using Locadora.Services.Autor;
using Locadora.Services.Livro;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Locadora.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Autor")]
    public class LivroController : ControllerBase
    {
        private readonly ILivroInterface _livroInterface;

        public LivroController(ILivroInterface livroInterface)
        {
            _livroInterface = livroInterface;
        }

        [HttpGet("ListarLivros")]
        public async Task<ActionResult<ResponseModel<List<LivroModel>>>> ListarLivros()
        {
            var livros = await _livroInterface.ListarLivros();

            return Ok(livros);
        }

        [HttpGet("BuscarLivroPorId/{idLivro}")]
        public async Task<ActionResult<ResponseModel<LivroModel>>> BuscarLivroPorId(int idLivro)
        {
            var livro = await _livroInterface.BuscarLivroPorId(idLivro);

            return Ok(livro);
        }

        [HttpGet("BuscarLivroPorAutorId/{idAutor}")]
        public async Task<ActionResult<ResponseModel<LivroModel>>> BuscarLivroPorAutorId(int idAutor)
        {
            var livro = await _livroInterface.BuscarLivroPorIdAutor(idAutor);

            return Ok(livro);
        }

        [HttpPost("CriarLivro")]
        public async Task<ActionResult<ResponseModel<List<LivroModel>>>> CriarLivro(LivroCriacaoDto livroCriacaoDto)
        {
            var livros = await _livroInterface.CriarLivro(livroCriacaoDto);
            return Ok(livros);
        }

        [HttpPut("EditarLivro")]
        public async Task<ActionResult<ResponseModel<List<LivroModel>>>> EditarLivro(LivroEdicaoDto livroEdicaoDto)
        {
            var livros = await _livroInterface.EditarLivro(livroEdicaoDto);
            return Ok(livros);
        }

        [HttpDelete("ExcluirLivro")]
        public async Task<ActionResult<ResponseModel<List<LivroModel>>>> EditarLivro(int idLivro)
        {
            var livros = await _livroInterface.ExcluirLivro(idLivro);
            return Ok(livros);
        }
    }
}
