namespace Black.OpenGL;

/* 
removes extensions
.*_(ext|arb|sgix|oes|angle|nv|khr|eac).*\n

replaces find result wiht enum -> 
.*value="(.\w*)" name="(\w*).*
	$2 = $1,
*/
/* 
 name to cs name
_(\w*)
\L$1
*/

public enum InternalPixelFormats : uint
{
	StencilIndex                          	= 0x1901,
	DepthComponent                        	= 0x1902,
	Red                                   	= 0x1903,
	Rgb                                   	= 0x1907,
	Rgba                                  	= 0x1908,
	R3g3b2                                	= 0x2a10,
	Alpha4                                	= 0x803b,
	Alpha8                                	= 0x803c,
	Alpha12                               	= 0x803d,
	Alpha16                               	= 0x803e,
	Luminance4                            	= 0x803f,
	Luminance8                            	= 0x8040,
	Luminance12                           	= 0x8041,
	Luminance16                           	= 0x8042,
	Luminance4Alpha4                      	= 0x8043,
	Luminance6Alpha2                      	= 0x8044,
	Luminance8Alpha8                      	= 0x8045,
	Luminance12Alpha4                     	= 0x8046,
	Luminance12Alpha12                    	= 0x8047,
	Luminance16Alpha16                    	= 0x8048,
	Intensity                             	= 0x8049,
	Intensity4                            	= 0x804a,
	Intensity8                            	= 0x804b,
	Intensity12                           	= 0x804c,
	Intensity16                           	= 0x804d,
	Rgb4                                  	= 0x804f,
	Rgb5                                  	= 0x8050,
	Rgb8                                  	= 0x8051,
	Rgb10                                 	= 0x8052,
	Rgb12                                 	= 0x8053,
	Rgb16                                 	= 0x8054,
	Rgba2                                 	= 0x8055,
	Rgba4                                 	= 0x8056,
	Rgb5a1                                	= 0x8057,
	Rgba8                                 	= 0x8058,
	Rgb10a2                               	= 0x8059,
	Rgba12                                	= 0x805a,
	Rgba16                                	= 0x805b,
	DepthComponent16                      	= 0x81a5,
	DepthComponent24                      	= 0x81a6,
	DepthComponent32                      	= 0x81a7,
	CompressedRed                         	= 0x8225,
	CompressedRg                          	= 0x8226,
	Rg                                    	= 0x8227,
	R8                                    	= 0x8229,
	R16                                   	= 0x822a,
	Rg8                                   	= 0x822b,
	Rg16                                  	= 0x822c,
	R16F                                  	= 0x822d,
	R32F                                  	= 0x822e,
	Rg16F                                 	= 0x822f,
	Rg32F                                 	= 0x8230,
	R8I                                   	= 0x8231,
	R8Ui                                  	= 0x8232,
	R16I                                  	= 0x8233,
	R16Ui                                 	= 0x8234,
	R32I                                  	= 0x8235,
	R32Ui                                 	= 0x8236,
	Rg8I                                  	= 0x8237,
	Rg8Ui                                 	= 0x8238,
	Rg16I                                 	= 0x8239,
	Rg16Ui                                	= 0x823a,
	Rg32I                                 	= 0x823b,
	Rg32Ui                                	= 0x823c,
	CompressedRgb                         	= 0x84ed,
	CompressedRgba                        	= 0x84ee,
	DepthStencil                          	= 0x84f9,
	Rgba32F                               	= 0x8814,
	Rgb32F                                	= 0x8815,
	Rgba16F                               	= 0x881a,
	Rgb16F                                	= 0x881b,
	Depth24Stencil8                       	= 0x88f0,
	R11Fg11Fb10F                          	= 0x8c3a,
	Rgb9e5                                	= 0x8c3d,
	Srgb                                  	= 0x8c40,
	Srgb8                                 	= 0x8c41,
	SrgbAlpha                             	= 0x8c42,
	Srgb8Alpha8                           	= 0x8c43,
	CompressedSrgb                        	= 0x8c48,
	CompressedSrgbAlpha                   	= 0x8c49,
	DepthComponent32F                     	= 0x8cac,
	Depth32FStencil8                      	= 0x8cad,
	StencilIndex1                         	= 0x8d46,
	StencilIndex4                         	= 0x8d47,
	StencilIndex8                         	= 0x8d48,
	StencilIndex16                        	= 0x8d49,
	Rgb565                                	= 0x8d62,
	Rgba32Ui                              	= 0x8d70,
	Rgb32Ui                               	= 0x8d71,
	Rgba16Ui                              	= 0x8d76,
	Rgb16Ui                               	= 0x8d77,
	Rgba8Ui                               	= 0x8d7c,
	Rgb8Ui                                	= 0x8d7d,
	Rgba32I                               	= 0x8d82,
	Rgb32I                                	= 0x8d83,
	Rgba16I                               	= 0x8d88,
	Rgb16I                                	= 0x8d89,
	Rgba8I                                	= 0x8d8e,
	Rgb8I                                 	= 0x8d8f,
	CompressedRedRgtc1                    	= 0x8dbb,
	CompressedSignedRedRgtc1              	= 0x8dbc,
	CompressedRgRgtc2                     	= 0x8dbd,
	CompressedSignedRgRgtc2               	= 0x8dbe,
	CompressedRgbaBptcUnorm               	= 0x8e8c,
	CompressedSrgbAlphaBptcUnorm          	= 0x8e8d,
	CompressedRgbBptcSignedFloat          	= 0x8e8e,
	CompressedRgbBptcUnsignedFloat        	= 0x8e8f,
	R8Snorm                               	= 0x8f94,
	Rg8Snorm                              	= 0x8f95,
	Rgb8Snorm                             	= 0x8f96,
	Rgba8Snorm                            	= 0x8f97,
	R16Snorm                              	= 0x8f98,
	Rg16Snorm                             	= 0x8f99,
	Rgb16Snorm                            	= 0x8f9a,
	Rgba16Snorm                           	= 0x8f9b,
	Rgb10a2Ui                             	= 0x906f,
	CompressedRgb8Etc2                    	= 0x9274,
	CompressedSrgb8Etc2                   	= 0x9275,
	CompressedRgb8PunchthroughAlpha1Etc2  	= 0x9276,
	CompressedSrgb8PunchthroughAlpha1Etc2 	= 0x9277,
	CompressedRgbaAstc4x4                 	= 0x93b0,
	CompressedRgbaAstc5x4                 	= 0x93b1,
	CompressedRgbaAstc5x5                 	= 0x93b2,
	CompressedRgbaAstc6x5                 	= 0x93b3,
	CompressedRgbaAstc6x6                 	= 0x93b4,
	CompressedRgbaAstc8x5                 	= 0x93b5,
	CompressedRgbaAstc8x6                 	= 0x93b6,
	CompressedRgbaAstc8x8                 	= 0x93b7,
	CompressedRgbaAstc10x5                	= 0x93b8,
	CompressedRgbaAstc10x6                	= 0x93b9,
	CompressedRgbaAstc10x8                	= 0x93ba,
	CompressedRgbaAstc10x10               	= 0x93bb,
	CompressedRgbaAstc12x10               	= 0x93bc,
	CompressedRgbaAstc12x12               	= 0x93bd,
	CompressedSrgb8Alpha8Astc4x4          	= 0x93d0,
	CompressedSrgb8Alpha8Astc5x4          	= 0x93d1,
	CompressedSrgb8Alpha8Astc5x5          	= 0x93d2,
	CompressedSrgb8Alpha8Astc6x5          	= 0x93d3,
	CompressedSrgb8Alpha8Astc6x6          	= 0x93d4,
	CompressedSrgb8Alpha8Astc8x5          	= 0x93d5,
	CompressedSrgb8Alpha8Astc8x6          	= 0x93d6,
	CompressedSrgb8Alpha8Astc8x8          	= 0x93d7,
	CompressedSrgb8Alpha8Astc10x5         	= 0x93d8,
	CompressedSrgb8Alpha8Astc10x6         	= 0x93d9,
	CompressedSrgb8Alpha8Astc10x8         	= 0x93da,
	CompressedSrgb8Alpha8Astc10x10        	= 0x93db,
	CompressedSrgb8Alpha8Astc12x10        	= 0x93dc,
	CompressedSrgb8Alpha8Astc12x12        	= 0x93dd,
}

public enum PixelFormats : uint
{
	UnsignedShort  							= 0x1403,
	UnsignedInt    							= 0x1405,
	ColorIndex     							= 0x1900,
	StencilIndex   							= 0x1901,
	DepthComponent 							= 0x1902,
	Red            							= 0x1903,
	Green          							= 0x1904,
	Blue           							= 0x1905,
	Alpha          							= 0x1906,
	Rgb            							= 0x1907,
	Rgba           							= 0x1908,
	Luminance      							= 0x1909,
	LuminanceAlpha 							= 0x190a,
	Bgr            							= 0x80e0,
	Bgra           							= 0x80e1,
	Rg             							= 0x8227,
	RgInteger      							= 0x8228,
	DepthStencil   							= 0x84f9,
	RedInteger     							= 0x8d94,
	GreenInteger   							= 0x8d95,
	BlueInteger    							= 0x8d96,
	RgbInteger     							= 0x8d98,
	RgbaInteger    							= 0x8d99,
	BgrInteger     							= 0x8d9a,
	BgraInteger    							= 0x8d9b,
}

public enum PixelSizedInternalFormats : uint
{
	R3g3b2                                	= 0x2a10,
	Alpha4                                	= 0x803b,
	Alpha8                                	= 0x803c,
	Alpha12                               	= 0x803d,
	Alpha16                               	= 0x803e,
	Luminance4                            	= 0x803f,
	Luminance8                            	= 0x8040,
	Luminance12                           	= 0x8041,
	Luminance16                           	= 0x8042,
	Luminance4Alpha4                      	= 0x8043,
	Luminance6Alpha2                      	= 0x8044,
	Luminance8Alpha8                      	= 0x8045,
	Luminance12Alpha4                     	= 0x8046,
	Luminance12Alpha12                    	= 0x8047,
	Luminance16Alpha16                    	= 0x8048,
	Intensity4                            	= 0x804a,
	Intensity8                            	= 0x804b,
	Intensity12                           	= 0x804c,
	Intensity16                           	= 0x804d,
	Rgb4                                  	= 0x804f,
	Rgb5                                  	= 0x8050,
	Rgb8                                  	= 0x8051,
	Rgb10                                 	= 0x8052,
	Rgb12                                 	= 0x8053,
	Rgb16                                 	= 0x8054,
	Rgba2                                 	= 0x8055,
	Rgba4                                 	= 0x8056,
	Rgb5a1                                	= 0x8057,
	Rgba8                                 	= 0x8058,
	Rgb10a2                               	= 0x8059,
	Rgba12                                	= 0x805a,
	Rgba16                                	= 0x805b,
	DepthComponent16                      	= 0x81a5,
	DepthComponent24                      	= 0x81a6,
	DepthComponent32                      	= 0x81a7,
	R8                                    	= 0x8229,
	R16                                   	= 0x822a,
	Rg8                                   	= 0x822b,
	Rg16                                  	= 0x822c,
	R16F                                  	= 0x822d,
	R32F                                  	= 0x822e,
	Rg16F                                 	= 0x822f,
	Rg32F                                 	= 0x8230,
	R8I                                   	= 0x8231,
	R8Ui                                  	= 0x8232,
	R16I                                  	= 0x8233,
	R16Ui                                 	= 0x8234,
	R32I                                  	= 0x8235,
	R32Ui                                 	= 0x8236,
	Rg8I                                  	= 0x8237,
	Rg8Ui                                 	= 0x8238,
	Rg16I                                 	= 0x8239,
	Rg16Ui                                	= 0x823a,
	Rg32I                                 	= 0x823b,
	Rg32Ui                                	= 0x823c,
	Rgba32F                               	= 0x8814,
	Rgb32F                                	= 0x8815,
	Rgba16F                               	= 0x881a,
	Rgb16F                                	= 0x881b,
	Depth24Stencil8                       	= 0x88f0,
	R11Fg11Fb10F                          	= 0x8c3a,
	R11Fg11Fb10FApple                     	= 0x8c3a,
	Rgb9e5                                	= 0x8c3d,
	Rgb9e5Apple                           	= 0x8c3d,
	Srgb8                                 	= 0x8c41,
	Srgb8Alpha8                           	= 0x8c43,
	DepthComponent32F                     	= 0x8cac,
	Depth32FStencil8                      	= 0x8cad,
	StencilIndex1                         	= 0x8d46,
	StencilIndex4                         	= 0x8d47,
	StencilIndex8                         	= 0x8d48,
	StencilIndex16                        	= 0x8d49,
	Rgb565                                	= 0x8d62,
	Rgba32Ui                              	= 0x8d70,
	Rgb32Ui                               	= 0x8d71,
	Rgba16Ui                              	= 0x8d76,
	Rgb16Ui                               	= 0x8d77,
	Rgba8Ui                               	= 0x8d7c,
	Rgb8Ui                                	= 0x8d7d,
	Rgba32I                               	= 0x8d82,
	Rgb32I                                	= 0x8d83,
	Rgba16I                               	= 0x8d88,
	Rgb16I                                	= 0x8d89,
	Rgba8I                                	= 0x8d8e,
	Rgb8I                                 	= 0x8d8f,
	CompressedRedRgtc1                    	= 0x8dbb,
	CompressedSignedRedRgtc1              	= 0x8dbc,
	CompressedRgRgtc2                     	= 0x8dbd,
	CompressedSignedRgRgtc2               	= 0x8dbe,
	CompressedRgbaBptcUnorm               	= 0x8e8c,
	CompressedSrgbAlphaBptcUnorm          	= 0x8e8d,
	CompressedRgbBptcSignedFloat          	= 0x8e8e,
	CompressedRgbBptcUnsignedFloat        	= 0x8e8f,
	R8Snorm                               	= 0x8f94,
	Rg8Snorm                              	= 0x8f95,
	Rgb8Snorm                             	= 0x8f96,
	Rgba8Snorm                            	= 0x8f97,
	R16Snorm                              	= 0x8f98,
	Rg16Snorm                             	= 0x8f99,
	Rgb16Snorm                            	= 0x8f9a,
	Rgba16Snorm                           	= 0x8f9b,
	Rgb10a2Ui                             	= 0x906f,
	CompressedRgb8Etc2                    	= 0x9274,
	CompressedSrgb8Etc2                   	= 0x9275,
	CompressedRgb8PunchthroughAlpha1Etc2  	= 0x9276,
	CompressedSrgb8PunchthroughAlpha1Etc2 	= 0x9277,
	CompressedRgbaAstc4x4                 	= 0x93b0,
	CompressedRgbaAstc5x4                 	= 0x93b1,
	CompressedRgbaAstc5x5                 	= 0x93b2,
	CompressedRgbaAstc6x5                 	= 0x93b3,
	CompressedRgbaAstc6x6                 	= 0x93b4,
	CompressedRgbaAstc8x5                 	= 0x93b5,
	CompressedRgbaAstc8x6                 	= 0x93b6,
	CompressedRgbaAstc8x8                 	= 0x93b7,
	CompressedRgbaAstc10x5                	= 0x93b8,
	CompressedRgbaAstc10x6                	= 0x93b9,
	CompressedRgbaAstc10x8                	= 0x93ba,
	CompressedRgbaAstc10x10               	= 0x93bb,
	CompressedRgbaAstc12x10               	= 0x93bc,
	CompressedRgbaAstc12x12               	= 0x93bd,
	CompressedSrgb8Alpha8Astc4x4          	= 0x93d0,
	CompressedSrgb8Alpha8Astc5x4          	= 0x93d1,
	CompressedSrgb8Alpha8Astc5x5          	= 0x93d2,
	CompressedSrgb8Alpha8Astc6x5          	= 0x93d3,
	CompressedSrgb8Alpha8Astc6x6          	= 0x93d4,
	CompressedSrgb8Alpha8Astc8x5          	= 0x93d5,
	CompressedSrgb8Alpha8Astc8x6          	= 0x93d6,
	CompressedSrgb8Alpha8Astc8x8          	= 0x93d7,
	CompressedSrgb8Alpha8Astc10x5         	= 0x93d8,
	CompressedSrgb8Alpha8Astc10x6         	= 0x93d9,
	CompressedSrgb8Alpha8Astc10x8         	= 0x93da,
	CompressedSrgb8Alpha8Astc10x10        	= 0x93db,
	CompressedSrgb8Alpha8Astc12x10        	= 0x93dc,
	CompressedSrgb8Alpha8Astc12x12        	= 0x93dd,
}