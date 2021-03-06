/*
Copyright (C) 2018-2019 de4dot@gmail.com

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

#if !NO_MASM_FORMATTER && !NO_FORMATTER
using System.Collections.Generic;
using Xunit;

namespace Iced.UnitTests.Intel.FormatterTests.Masm {
	public sealed class MasmFormatterTest64_NoMemSize_008 : FormatterTest {
		[Theory]
		[MemberData(nameof(Format_Data))]
		void Format(int index, InstructionInfo info, string formattedString) => FormatBase(index, info, formattedString, MasmFormatterFactory.Create_NoMemSize());
		public static IEnumerable<object[]> Format_Data => GetFormatData(infos, formattedStrings);

		static readonly InstructionInfo[] infos = InstructionInfos64_008.AllInfos;
		static readonly string[] formattedStrings = new string[InstructionInfos64_008.AllInfos_Length] {
			"vpcompressb zmm19{k3}{z},zmm10",
			"vpcompressb [rax+1],zmm2",
			"vpcompressw xmm3,xmm2",
			"vpcompressw [rax+2],xmm2",
			"vpcompressw ymm3{k3},ymm2",
			"vpcompressw [rax+2]{k3},ymm2",
			"vpcompressw zmm19{k3}{z},zmm10",
			"vpcompressw [rax+2],zmm2",
			"vpshldvw xmm2{k3},xmm6,xmm3",
			"vpshldvw xmm2,xmm6,[rax+10h]",
			"vpshldvw ymm2{k3},ymm6,ymm3",
			"vpshldvw ymm2{k3},ymm6,[rax+20h]",
			"vpshldvw zmm18{k3}{z},zmm14,zmm3",
			"vpshldvw zmm2{k3}{z},zmm6,[rax+40h]",
			"vpshldvd xmm18{k3},xmm14,xmm3",
			"vpshldvd xmm2,xmm6,[rax+10h]",
			"vpshldvd xmm2{k5}{z},xmm6,dword bcst [rax+4]",
			"vpshldvd ymm18{k3},ymm14,ymm3",
			"vpshldvd ymm2{k3},ymm6,[rax+20h]",
			"vpshldvd ymm2{k5}{z},ymm6,dword bcst [rax+4]",
			"vpshldvd zmm2{k3}{z},zmm6,zmm3",
			"vpshldvd zmm2,zmm6,[rax+40h]",
			"vpshldvd zmm2{k5}{z},zmm6,dword bcst [rax+4]",
			"vpshldvq xmm18{k3},xmm14,xmm3",
			"vpshldvq xmm2,xmm6,[rax+10h]",
			"vpshldvq xmm2{k5}{z},xmm6,qword bcst [rax+8]",
			"vpshldvq ymm18{k3},ymm14,ymm3",
			"vpshldvq ymm2{k3},ymm6,[rax+20h]",
			"vpshldvq ymm2{k5}{z},ymm6,qword bcst [rax+8]",
			"vpshldvq zmm2{k3}{z},zmm6,zmm3",
			"vpshldvq zmm2,zmm6,[rax+40h]",
			"vpshldvq zmm2{k5}{z},zmm6,qword bcst [rax+8]",
			"vpshrdvw xmm2{k3},xmm6,xmm3",
			"vpshrdvw xmm2,xmm6,[rax+10h]",
			"vpshrdvw ymm2{k3},ymm6,ymm3",
			"vpshrdvw ymm2{k3},ymm6,[rax+20h]",
			"vpshrdvw zmm18{k3}{z},zmm14,zmm3",
			"vpshrdvw zmm2{k3}{z},zmm6,[rax+40h]",
			"vpshrdvd xmm18{k3},xmm14,xmm3",
			"vpshrdvd xmm2,xmm6,[rax+10h]",
			"vpshrdvd xmm2{k5}{z},xmm6,dword bcst [rax+4]",
			"vpshrdvd ymm18{k3},ymm14,ymm3",
			"vpshrdvd ymm2{k3},ymm6,[rax+20h]",
			"vpshrdvd ymm2{k5}{z},ymm6,dword bcst [rax+4]",
			"vpshrdvd zmm2{k3}{z},zmm6,zmm3",
			"vpshrdvd zmm2,zmm6,[rax+40h]",
			"vpshrdvd zmm2{k5}{z},zmm6,dword bcst [rax+4]",
			"vpshrdvq xmm18{k3},xmm14,xmm3",
			"vpshrdvq xmm2,xmm6,[rax+10h]",
			"vpshrdvq xmm2{k5}{z},xmm6,qword bcst [rax+8]",
			"vpshrdvq ymm18{k3},ymm14,ymm3",
			"vpshrdvq ymm2{k3},ymm6,[rax+20h]",
			"vpshrdvq ymm2{k5}{z},ymm6,qword bcst [rax+8]",
			"vpshrdvq zmm2{k3}{z},zmm6,zmm3",
			"vpshrdvq zmm2,zmm6,[rax+40h]",
			"vpshrdvq zmm2{k5}{z},zmm6,qword bcst [rax+8]",
			"vpshufbitqmb k2{k3},xmm6,xmm3",
			"vpshufbitqmb k2,xmm6,[rax+10h]",
			"vpshufbitqmb k2{k3},ymm6,ymm3",
			"vpshufbitqmb k2{k3},ymm6,[rax+20h]",
			"vpshufbitqmb k2{k3},zmm6,zmm3",
			"vpshufbitqmb k2,zmm6,[rax+40h]",
			"gf2p8mulb xmm1,xmm5",
			"gf2p8mulb xmm1,[rax]",
			"vgf2p8mulb xmm2,xmm6,xmm3",
			"vgf2p8mulb xmm2,xmm6,[rax]",
			"vgf2p8mulb ymm2,ymm6,ymm3",
			"vgf2p8mulb ymm2,ymm6,[rax]",
			"vgf2p8mulb xmm2{k3},xmm6,xmm3",
			"vgf2p8mulb xmm2,xmm6,[rax+10h]",
			"vgf2p8mulb ymm2{k3},ymm6,ymm3",
			"vgf2p8mulb ymm2{k3},ymm6,[rax+20h]",
			"vgf2p8mulb zmm18{k3}{z},zmm14,zmm3",
			"vgf2p8mulb zmm2{k5}{z},zmm6,[rax+40h]",
			"vaesenc ymm2,ymm6,ymm3",
			"vaesenc ymm2,ymm6,[rax]",
			"vaesenc xmm2,xmm6,xmm3",
			"vaesenc xmm2,xmm6,[rax+10h]",
			"vaesenc ymm2,ymm6,ymm3",
			"vaesenc ymm2,ymm6,[rax+20h]",
			"vaesenc zmm2,zmm6,zmm3",
			"vaesenc zmm2,zmm6,[rax+40h]",
			"vaesenclast ymm2,ymm6,ymm3",
			"vaesenclast ymm2,ymm6,[rax]",
			"vaesenclast xmm2,xmm6,xmm3",
			"vaesenclast xmm2,xmm6,[rax+10h]",
			"vaesenclast ymm2,ymm6,ymm3",
			"vaesenclast ymm2,ymm6,[rax+20h]",
			"vaesenclast zmm2,zmm6,zmm3",
			"vaesenclast zmm2,zmm6,[rax+40h]",
			"vaesdec ymm2,ymm6,ymm3",
			"vaesdec ymm2,ymm6,[rax]",
			"vaesdec xmm2,xmm6,xmm3",
			"vaesdec xmm2,xmm6,[rax+10h]",
			"vaesdec ymm2,ymm6,ymm3",
			"vaesdec ymm2,ymm6,[rax+20h]",
			"vaesdec zmm2,zmm6,zmm3",
			"vaesdec zmm2,zmm6,[rax+40h]",
			"vaesdeclast ymm2,ymm6,ymm3",
			"vaesdeclast ymm2,ymm6,[rax]",
			"vaesdeclast xmm2,xmm6,xmm3",
			"vaesdeclast xmm2,xmm6,[rax+10h]",
			"vaesdeclast ymm2,ymm6,ymm3",
			"vaesdeclast ymm2,ymm6,[rax+20h]",
			"vaesdeclast zmm2,zmm6,zmm3",
			"vaesdeclast zmm2,zmm6,[rax+40h]",
			"wrussd [rax],ebx",
			"wrussq [rax],rbx",
			"wrssd [rax],ebx",
			"wrssq [rax],rbx",
			"movdir64b ebx,[eax]",
			"movdir64b rbx,[rax]",
			"movdiri [rax],ebx",
			"movdiri [rax],rbx",
			"vpclmulqdq ymm2,ymm6,ymm3,0A5h",
			"vpclmulqdq ymm2,ymm6,[rax],0A5h",
			"vpclmulqdq xmm2,xmm6,xmm3,0A5h",
			"vpclmulqdq xmm2,xmm6,[rax+10h],0A5h",
			"vpclmulqdq ymm2,ymm6,ymm3,0A5h",
			"vpclmulqdq ymm2,ymm6,[rax+20h],0A5h",
			"vpclmulqdq zmm2,zmm6,zmm3,0A5h",
			"vpclmulqdq zmm2,zmm6,[rax+40h],0A5h",
			"vpshldw xmm2{k3},xmm6,xmm3,0A5h",
			"vpshldw xmm2{k3},xmm6,[rax+10h],0A5h",
			"vpshldw ymm18{k3}{z},ymm14,ymm3,0A5h",
			"vpshldw ymm2{k5}{z},ymm6,[rax+20h],0A5h",
			"vpshldw zmm2{k3},zmm6,zmm3,0A5h",
			"vpshldw zmm2,zmm6,[rax+40h],0A5h",
			"vpshldd xmm2{k3},xmm6,xmm3,0A5h",
			"vpshldd xmm2{k3},xmm6,[rax+10h],0A5h",
			"vpshldd xmm2{k5}{z},xmm6,dword bcst [rax+4],0A5h",
			"vpshldd ymm2{k3}{z},ymm6,ymm3,0A5h",
			"vpshldd ymm2,ymm6,[rax+20h],0A5h",
			"vpshldd ymm2{k5}{z},ymm6,dword bcst [rax+4],0A5h",
			"vpshldd zmm2{k3},zmm6,zmm3,0A5h",
			"vpshldd zmm2,zmm6,[rax+40h],0A5h",
			"vpshldd zmm2{k5}{z},zmm6,dword bcst [rax+4],0A5h",
			"vpshldq xmm18{k3},xmm14,xmm3,0A5h",
			"vpshldq xmm2{k3},xmm6,[rax+10h],0A5h",
			"vpshldq xmm2{k5}{z},xmm6,qword bcst [rax+8],0A5h",
			"vpshldq ymm2{k3}{z},ymm6,ymm3,0A5h",
			"vpshldq ymm2,ymm6,[rax+20h],0A5h",
			"vpshldq ymm2{k5}{z},ymm6,qword bcst [rax+8],0A5h",
			"vpshldq zmm18{k3},zmm14,zmm3,0A5h",
			"vpshldq zmm2,zmm6,[rax+40h],0A5h",
			"vpshldq zmm2{k5}{z},zmm6,qword bcst [rax+8],0A5h",
			"vpshrdw xmm2{k3},xmm6,xmm3,0A5h",
			"vpshrdw xmm2{k3},xmm6,[rax+10h],0A5h",
			"vpshrdw ymm18{k3}{z},ymm14,ymm3,0A5h",
			"vpshrdw ymm2{k5}{z},ymm6,[rax+20h],0A5h",
			"vpshrdw zmm2{k3},zmm6,zmm3,0A5h",
			"vpshrdw zmm2,zmm6,[rax+40h],0A5h",
			"vpshrdd xmm2{k3},xmm6,xmm3,0A5h",
			"vpshrdd xmm2{k3},xmm6,[rax+10h],0A5h",
			"vpshrdd xmm2{k5}{z},xmm6,dword bcst [rax+4],0A5h",
			"vpshrdd ymm2{k3}{z},ymm6,ymm3,0A5h",
			"vpshrdd ymm2,ymm6,[rax+20h],0A5h",
			"vpshrdd ymm2{k5}{z},ymm6,dword bcst [rax+4],0A5h",
			"vpshrdd zmm2{k3},zmm6,zmm3,0A5h",
			"vpshrdd zmm2,zmm6,[rax+40h],0A5h",
			"vpshrdd zmm2{k5}{z},zmm6,dword bcst [rax+4],0A5h",
			"vpshrdq xmm18{k3},xmm14,xmm3,0A5h",
			"vpshrdq xmm2{k3},xmm6,[rax+10h],0A5h",
			"vpshrdq xmm2{k5}{z},xmm6,qword bcst [rax+8],0A5h",
			"vpshrdq ymm2{k3}{z},ymm6,ymm3,0A5h",
			"vpshrdq ymm2,ymm6,[rax+20h],0A5h",
			"vpshrdq ymm2{k5}{z},ymm6,qword bcst [rax+8],0A5h",
			"vpshrdq zmm18{k3},zmm14,zmm3,0A5h",
			"vpshrdq zmm2,zmm6,[rax+40h],0A5h",
			"vpshrdq zmm2{k5}{z},zmm6,qword bcst [rax+8],0A5h",
			"gf2p8affineqb xmm1,xmm5,0A5h",
			"gf2p8affineqb xmm1,[rax],0A5h",
			"vgf2p8affineqb xmm2,xmm6,xmm3,0A5h",
			"vgf2p8affineqb xmm2,xmm6,[rax],0A5h",
			"vgf2p8affineqb ymm2,ymm6,ymm3,0A5h",
			"vgf2p8affineqb ymm2,ymm6,[rax],0A5h",
			"vgf2p8affineqb xmm18{k3},xmm14,xmm3,0A5h",
			"vgf2p8affineqb xmm2{k3},xmm6,[rax+10h],0A5h",
			"vgf2p8affineqb xmm2{k5}{z},xmm6,qword bcst [rax+8],0A5h",
			"vgf2p8affineqb ymm2{k3}{z},ymm6,ymm3,0A5h",
			"vgf2p8affineqb ymm2,ymm6,[rax+20h],0A5h",
			"vgf2p8affineqb ymm2{k5}{z},ymm6,qword bcst [rax+8],0A5h",
			"vgf2p8affineqb zmm18{k3},zmm14,zmm3,0A5h",
			"vgf2p8affineqb zmm2,zmm6,[rax+40h],0A5h",
			"vgf2p8affineqb zmm2{k5}{z},zmm6,qword bcst [rax+8],0A5h",
			"gf2p8affineinvqb xmm1,xmm5,0A5h",
			"gf2p8affineinvqb xmm1,[rax],0A5h",
			"vgf2p8affineinvqb xmm2,xmm6,xmm3,0A5h",
			"vgf2p8affineinvqb xmm2,xmm6,[rax],0A5h",
			"vgf2p8affineinvqb ymm2,ymm6,ymm3,0A5h",
			"vgf2p8affineinvqb ymm2,ymm6,[rax],0A5h",
			"vgf2p8affineinvqb xmm18{k3},xmm14,xmm3,0A5h",
			"vgf2p8affineinvqb xmm2{k3},xmm6,[rax+10h],0A5h",
			"vgf2p8affineinvqb xmm2{k5}{z},xmm6,qword bcst [rax+8],0A5h",
			"vgf2p8affineinvqb ymm2{k3}{z},ymm6,ymm3,0A5h",
			"vgf2p8affineinvqb ymm2,ymm6,[rax+20h],0A5h",
			"vgf2p8affineinvqb ymm2{k5}{z},ymm6,qword bcst [rax+8],0A5h",
			"vgf2p8affineinvqb zmm18{k3},zmm14,zmm3,0A5h",
			"vgf2p8affineinvqb zmm2,zmm6,[rax+40h],0A5h",
			"vgf2p8affineinvqb zmm2{k5}{z},zmm6,qword bcst [rax+8],0A5h",
			"fs monitor eax,rcx,rdx",
			"fs monitor rax,rcx,rdx",
			"fs monitorx eax,rcx,rdx",
			"fs monitorx rax,rcx,rdx",
			"fs clzero",
			"fs clzero",
			"fs umonitor ebp",
			"fs umonitor rbp",
			"rep montmul",
			"rep montmul",
			"montmul",
			"montmul",
			"rep xsha1",
			"rep xsha1",
			"xsha1",
			"xsha1",
			"rep xsha256",
			"rep xsha256",
			"xsha256",
			"xsha256",
			"rep xstore",
			"rep xstore",
			"xstore",
			"xstore",
			"rep xcryptecb",
			"rep xcryptecb",
			"xcryptecb",
			"xcryptecb",
			"rep xcryptcbc",
			"rep xcryptcbc",
			"xcryptcbc",
			"xcryptcbc",
			"rep xcryptctr",
			"rep xcryptctr",
			"xcryptctr",
			"xcryptctr",
			"rep xcryptcfb",
			"rep xcryptcfb",
			"xcryptcfb",
			"xcryptcfb",
			"rep xcryptofb",
			"rep xcryptofb",
			"xcryptofb",
			"xcryptofb",
			"vdpbf16ps xmm18{k3},xmm14,xmm3",
			"vdpbf16ps xmm2,xmm6,[rax+10h]",
			"vdpbf16ps xmm2{k5}{z},xmm6,dword bcst [rax+4]",
			"vdpbf16ps ymm18{k3},ymm14,ymm3",
			"vdpbf16ps ymm2{k3},ymm6,[rax+20h]",
			"vdpbf16ps ymm2{k5}{z},ymm6,dword bcst [rax+4]",
			"vdpbf16ps zmm2{k3}{z},zmm6,zmm3",
			"vdpbf16ps zmm2,zmm6,[rax+40h]",
			"vdpbf16ps zmm2{k5}{z},zmm6,dword bcst [rax+4]",
			"vcvtneps2bf16 xmm2{k3}{z},xmm3",
			"vcvtneps2bf16 xmm2{k3},[rax+10h]",
			"vcvtneps2bf16 xmm2{k5}{z},dword bcst [rax+4]",
			"vcvtneps2bf16 xmm2{k3}{z},ymm3",
			"vcvtneps2bf16 xmm2{k3},[rax+20h]",
			"vcvtneps2bf16 xmm2{k5}{z},dword bcst [rax+4]",
			"vcvtneps2bf16 ymm2{k3}{z},zmm3",
			"vcvtneps2bf16 ymm2{k3},[rax+40h]",
			"vcvtneps2bf16 ymm2{k5}{z},dword bcst [rax+4]",
			"vcvtne2ps2bf16 xmm18{k3},xmm14,xmm3",
			"vcvtne2ps2bf16 xmm2,xmm6,[rax+10h]",
			"vcvtne2ps2bf16 xmm2{k5}{z},xmm6,dword bcst [rax+4]",
			"vcvtne2ps2bf16 ymm18{k3},ymm14,ymm3",
			"vcvtne2ps2bf16 ymm2{k3},ymm6,[rax+20h]",
			"vcvtne2ps2bf16 ymm2{k5}{z},ymm6,dword bcst [rax+4]",
			"vcvtne2ps2bf16 zmm2{k3}{z},zmm6,zmm3",
			"vcvtne2ps2bf16 zmm2,zmm6,[rax+40h]",
			"vcvtne2ps2bf16 zmm2{k5}{z},zmm6,dword bcst [rax+4]",
 		};
	}
}
#endif
