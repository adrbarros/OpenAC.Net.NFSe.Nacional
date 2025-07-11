﻿// ***********************************************************************
// Assembly         : OpenAC.Net.NFSe.Nacional
// Author           : RFTD
// Created          : 09-09-2023
//
// Last Modified By : RFTD
// Last Modified On : 09-09-2023
// ***********************************************************************
// <copyright file="EventoCancelamentoPorSubstituicao.cs" company="OpenAC .Net">
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
using OpenAC.Net.NFSe.Nacional.Common.Types;

namespace OpenAC.Net.NFSe.Nacional.Common.Model;

/// <summary>
/// Representa o evento de cancelamento de NFS-e por substituição.
/// </summary>
public sealed class EventoCancelamentoPorSubstituicao : IEventoNFSe
{
    /// <summary>
    /// Descrição do evento.
    /// </summary>
    [DFeElement(TipoCampo.Str, "xDesc", Ocorrencia = Ocorrencia.Obrigatoria)]
    public string Descricao { get; set; } = "Cancelamento de NFS-e por Substituição";
    
    /// <summary>
    /// Código do motivo da substituição.
    /// </summary>
    [DFeElement(TipoCampo.Enum, "cMotivo", Ocorrencia = Ocorrencia.Obrigatoria)]
    public JustificativaSubstituicao CodMotivo { get; set; }
    
    /// <summary>
    /// Motivo detalhado da substituição.
    /// </summary>
    [DFeElement(TipoCampo.Str, "xMotivo", Min = 15, Max = 255, Ocorrencia = Ocorrencia.Obrigatoria)]
    public string Motivo { get; set; } = string.Empty;
    
    /// <summary>
    /// Chave da NFS-e substituta.
    /// </summary>
    [DFeElement(TipoCampo.Str, "chSubstituta", Min = 50, Max = 50, Ocorrencia = Ocorrencia.Obrigatoria)]
    public string ChaveSubstituta { get; set; } = string.Empty;
}