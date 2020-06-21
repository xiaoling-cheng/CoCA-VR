﻿//////////////////////////////////////////////////////
// MK Glow Shader SM40 Geometry	HDRP				//
//					                                //
// Created by Michael Kremmel                       //
// www.michaelkremmel.de                            //
// Copyright © 2020 All rights reserved.            //
//////////////////////////////////////////////////////
Shader "Hidden/MK/Glow/MKGlowSM40GeometryHDRP"
{
	SubShader
	{
		Tags {"LightMode" = "Always" "RenderType"="Opaque" "PerformanceChecks"="False"}
		Cull Off ZWrite Off ZTest Always

		/////////////////////////////////////////////////////////////////////////////////////////////
        // Copy - 0
        /////////////////////////////////////////////////////////////////////////////////////////////
		Pass
		{
			HLSLPROGRAM
			#pragma target 4.0
			#pragma vertex vertEmpty
			#pragma geometry geomSimple
			#pragma fragment frag
			#pragma fragmentoption ARB_precision_hint_fastest

			#pragma only_renderers vulkan d3d11 glcore ps4 xboxone
			#pragma require mrt8 samplelod geometry
			#pragma exclude_renderers nomrt

			#define _GEOMETRY_SHADER
			#define _HDRP

			#include "../../Shaders/Inc/Copy.hlsl"
			ENDHLSL
		}

		/////////////////////////////////////////////////////////////////////////////////////////////
        // Presample - 1
        /////////////////////////////////////////////////////////////////////////////////////////////
		Pass
		{
			HLSLPROGRAM
			#pragma target 4.0
			#pragma vertex vertEmpty
			#pragma geometry geomSimple
			#pragma fragment frag
			#pragma fragmentoption ARB_precision_hint_fastest

			#pragma only_renderers vulkan d3d11 glcore ps4 xboxone
			#pragma require mrt8 samplelod geometry
			#pragma exclude_renderers nomrt

			#pragma multi_compile __ _NORMALMAP
			#pragma multi_compile __ _ALPHABLEND_ON
			#pragma multi_compile __ _ALPHAPREMULTIPLY_ON BILLBOARD_FACE_CAMERA_POS LOD_FADE_CROSSFADE _SUNDISK_NONE
			#pragma multi_compile __ OUTLINE_ON _COLORCOLOR_ON
			#pragma multi_compile __ UNDERLAY_ON

			#define _GEOMETRY_SHADER
			#define _HDRP

			#include "../../Shaders/Inc/Presample.hlsl"
			ENDHLSL
		}

		/////////////////////////////////////////////////////////////////////////////////////////////
        // Downsample - 2
        /////////////////////////////////////////////////////////////////////////////////////////////
		Pass
		{
			HLSLPROGRAM
			#pragma target 4.0
			#pragma vertex vertEmpty
			#pragma geometry geomSimple
			#pragma fragment frag
			#pragma fragmentoption ARB_precision_hint_fastest

			#pragma only_renderers vulkan d3d11 glcore ps4 xboxone
			#pragma require mrt8 samplelod geometry
			#pragma exclude_renderers nomrt

			#pragma multi_compile __ _NORMALMAP
			#pragma multi_compile __ _ALPHABLEND_ON
			#pragma multi_compile __ _ALPHAPREMULTIPLY_ON BILLBOARD_FACE_CAMERA_POS LOD_FADE_CROSSFADE _SUNDISK_NONE
			#pragma multi_compile __ OUTLINE_ON _COLORCOLOR_ON

			#define _GEOMETRY_SHADER
			#define _HDRP

			#include "../../Shaders/Inc/Downsample.hlsl"
			ENDHLSL
		}

		/////////////////////////////////////////////////////////////////////////////////////////////
        // Upsample - 3
        /////////////////////////////////////////////////////////////////////////////////////////////
		Pass
		{
			HLSLPROGRAM
			#pragma target 4.0
			#pragma vertex vertEmpty
			#pragma geometry geom
			#pragma fragment frag
			#pragma fragmentoption ARB_precision_hint_fastest

			#pragma only_renderers vulkan d3d11 glcore ps4 xboxone
			#pragma require mrt8 samplelod geometry
			#pragma exclude_renderers nomrt

			#pragma multi_compile __ _NORMALMAP
			#pragma multi_compile __ _ALPHABLEND_ON
			#pragma multi_compile __ _ALPHAPREMULTIPLY_ON BILLBOARD_FACE_CAMERA_POS LOD_FADE_CROSSFADE _SUNDISK_NONE
			#pragma multi_compile __ OUTLINE_ON _COLORCOLOR_ON

			#define _GEOMETRY_SHADER
			#define _HDRP

			#include "../../Shaders/Inc/Upsample.hlsl"
			ENDHLSL
		}

		/////////////////////////////////////////////////////////////////////////////////////////////
        // Composite - 4
        /////////////////////////////////////////////////////////////////////////////////////////////
		Pass
		{
			HLSLPROGRAM
			#pragma target 4.0
			#pragma vertex vertEmpty
			#pragma geometry geom
			#pragma fragment frag
			#pragma fragmentoption ARB_precision_hint_fastest

			#pragma only_renderers vulkan d3d11 glcore ps4 xboxone
			#pragma require mrt8 samplelod geometry
			#pragma exclude_renderers nomrt

			#pragma multi_compile __ _ALPHATEST_ON
			#pragma multi_compile __ _ALPHABLEND_ON
			#pragma multi_compile __ _ALPHAPREMULTIPLY_ON BILLBOARD_FACE_CAMERA_POS LOD_FADE_CROSSFADE _SUNDISK_NONE
			#pragma multi_compile __ OUTLINE_ON _COLORCOLOR_ON
			#pragma multi_compile __ UNDERLAY_ON

			#define _GEOMETRY_SHADER
			#define _HDRP

			#include "../../Shaders/Inc/Composite.hlsl"
			ENDHLSL
		}

		/////////////////////////////////////////////////////////////////////////////////////////////
        // Debug - 5
        /////////////////////////////////////////////////////////////////////////////////////////////
		Pass
		{
			HLSLPROGRAM
			#pragma target 4.0
			#pragma vertex vertEmpty
			#pragma geometry geom
			#pragma fragment frag
			#pragma fragmentoption ARB_precision_hint_fastest

			#pragma only_renderers vulkan d3d11 glcore ps4 xboxone
			#pragma require mrt8 samplelod geometry
			#pragma exclude_renderers nomrt
			
			#pragma multi_compile __ _EMISSION _METALLICGLOSSMAP _DETAIL_MULX2 _SPECULARHIGHLIGHTS_OFF _GLOSSYREFLECTIONS_OFF EDITOR_VISUALIZATION
			#pragma multi_compile __ _ALPHATEST_ON
			#pragma multi_compile __ _ALPHABLEND_ON
			#pragma multi_compile __ _ALPHAPREMULTIPLY_ON BILLBOARD_FACE_CAMERA_POS LOD_FADE_CROSSFADE _SUNDISK_NONE
			#pragma multi_compile __ OUTLINE_ON _COLORCOLOR_ON
			#pragma multi_compile __ UNDERLAY_ON

			#define _GEOMETRY_SHADER
			#define _HDRP
			
			#include "../../Shaders/Inc/Debug.hlsl"
			ENDHLSL
		}
	}
	//HDRP Requires at least SM5
	FallBack Off
}
