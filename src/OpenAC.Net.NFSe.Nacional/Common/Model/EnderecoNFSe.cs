// ***********************************************************************
// Assembly         : OpenAC.Net.NFSe.Nacional
// Author           : RFTD
// Created          : 09-09-2023
//
// Last Modified By : RFTD
// Last Modified On : 09-09-2023
// ***********************************************************************
// <copyright file="EnderecoNFSe.cs" company="OpenAC .Net">
//		        		   The MIT License (MIT)
//	     		    Copyright (c) 2014-2023 Grupo OpenAC.Net
//
//	 Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//	 The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//	 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
// ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
// </copyright>
// <summary></summary>
// ***********************************************************************

using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Serializer;

namespace OpenAC.Net.NFSe.Nacional.Common.Model;

/// <summary>
/// Representa o endereço utilizado na NFSe.
/// </summary>
public sealed class EnderecoNFSe
{
    #region Properties

    /// <summary>
    /// Município do endereço.
    /// </summary>
    [DFeItem(typeof(MunicipioNacional), "endNac")]
    [DFeItem(typeof(MunicipioExterior), "endExt")]
    public IMunicipio? Municipio { get; set; }

    /// <summary>
    /// Logradouro do endereço.
    /// </summary>
    [DFeElement(TipoCampo.Str, "xLgr", Min = 1, Max = 255, Ocorrencia = Ocorrencia.Obrigatoria)]
    public string Logradouro { get; set; } = string.Empty;

    /// <summary>
    /// Número do endereço.
    /// </summary>
    [DFeElement(TipoCampo.Str, "nro", Min = 1, Max = 60, Ocorrencia = Ocorrencia.Obrigatoria)]
    public string Numero { get; set; } = string.Empty;
    
    /// <summary>
    /// Complemento do endereço.
    /// </summary>
    [DFeElement(TipoCampo.Str, "xCpl", Min = 1, Max = 156, Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public string? Complemento { get; set; }
    
    /// <summary>
    /// Bairro do endereço.
    /// </summary>
    [DFeElement(TipoCampo.Str, "xBairro", Min = 1, Max = 60, Ocorrencia = Ocorrencia.Obrigatoria)]
    public string Bairro { get; set; } = string.Empty;
    
    #endregion Properties
}