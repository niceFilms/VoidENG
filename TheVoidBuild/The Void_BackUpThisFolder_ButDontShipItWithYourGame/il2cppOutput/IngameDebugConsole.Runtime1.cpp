#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>
#include <stdint.h>



struct Action_1_tE8693FF0E67CDBA52BAFB211BFF1844D076ABAFB;
struct AsyncOperation_tD2789250E4B098DEDA92B366A577E500A92D2D3C;
struct SceneCommands_tD919696B0B3F4F289ECA77E9E677A51579914472;
struct String_t;
struct TimeCommands_t6DE00ACD4923F4291E15DF7C6CE0C4F9FE100901;
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915;

IL2CPP_EXTERN_C RuntimeClass* Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* SceneManager_tA0EF56A88ACA4A15731AF7FDC10A869FA4C698FA_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C String_t* _stringLiteral14EFC2C6E9EEDD3D7AD722A958977C463EF508F0;
IL2CPP_EXTERN_C String_t* _stringLiteral813C79655CE3ED707AE14612C0DEA0D767D00F51;


IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
struct Il2CppArrayBounds;

struct SceneCommands_tD919696B0B3F4F289ECA77E9E677A51579914472  : public RuntimeObject
{
};

struct String_t  : public RuntimeObject
{
	int32_t ____stringLength_4;
	Il2CppChar ____firstChar_5;
};

struct String_t_StaticFields
{
	String_t* ___Empty_6;
};

struct TimeCommands_t6DE00ACD4923F4291E15DF7C6CE0C4F9FE100901  : public RuntimeObject
{
};

struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F  : public RuntimeObject
{
};
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_pinvoke
{
};
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_com
{
};

struct YieldInstruction_tFCE35FD0907950EFEE9BC2890AC664E41C53728D  : public RuntimeObject
{
};
struct YieldInstruction_tFCE35FD0907950EFEE9BC2890AC664E41C53728D_marshaled_pinvoke
{
};
struct YieldInstruction_tFCE35FD0907950EFEE9BC2890AC664E41C53728D_marshaled_com
{
};

struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22 
{
	bool ___m_value_0;
};

struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_StaticFields
{
	String_t* ___TrueString_5;
	String_t* ___FalseString_6;
};

struct IntPtr_t 
{
	void* ___m_value_0;
};

struct IntPtr_t_StaticFields
{
	intptr_t ___Zero_1;
};

struct Scene_tA1DC762B79745EB5140F054C884855B922318356 
{
	int32_t ___m_Handle_0;
};

struct Single_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C 
{
	float ___m_value_0;
};

struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915 
{
	union
	{
		struct
		{
		};
		uint8_t Void_t4861ACF8F4594C3437BB48B6E56783494B843915__padding[1];
	};
};

struct AsyncOperation_tD2789250E4B098DEDA92B366A577E500A92D2D3C  : public YieldInstruction_tFCE35FD0907950EFEE9BC2890AC664E41C53728D
{
	intptr_t ___m_Ptr_0;
	Action_1_tE8693FF0E67CDBA52BAFB211BFF1844D076ABAFB* ___m_completeCallback_1;
};
struct AsyncOperation_tD2789250E4B098DEDA92B366A577E500A92D2D3C_marshaled_pinvoke : public YieldInstruction_tFCE35FD0907950EFEE9BC2890AC664E41C53728D_marshaled_pinvoke
{
	intptr_t ___m_Ptr_0;
	Il2CppMethodPointer ___m_completeCallback_1;
};
struct AsyncOperation_tD2789250E4B098DEDA92B366A577E500A92D2D3C_marshaled_com : public YieldInstruction_tFCE35FD0907950EFEE9BC2890AC664E41C53728D_marshaled_com
{
	intptr_t ___m_Ptr_0;
	Il2CppMethodPointer ___m_completeCallback_1;
};
#ifdef __clang__
#pragma clang diagnostic pop
#endif



IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SceneCommands_LoadSceneInternal_m44750C6CBF099D1649D013DE26C8E6C838AA234B (String_t* ___sceneName0, bool ___isAsync1, int32_t ___mode2, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Scene_tA1DC762B79745EB5140F054C884855B922318356 SceneManager_GetSceneByName_m2A70CB2D1C586ED6747E82693785CA86F99FA9B9 (String_t* ___name0, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Scene_IsValid_m0D5200731D3E26ECBBB55803F9242965A14A4599 (Scene_tA1DC762B79745EB5140F054C884855B922318356* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m8855A6DE10F84DA7F4EC113CADDB59873A25573B (String_t* ___str00, String_t* ___str11, String_t* ___str22, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Debug_Log_m87A9A3C761FF5C43ED8A53B16190A53D08F818BB (RuntimeObject* ___message0, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AsyncOperation_tD2789250E4B098DEDA92B366A577E500A92D2D3C* SceneManager_LoadSceneAsync_m29D55D2C6CB7A019B26DA3F44C0881FF6AC491EC (String_t* ___sceneName0, int32_t ___mode1, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SceneManager_LoadScene_m2841705C02C450E42A44B5EEE2A6A2C4261FA3AF (String_t* ___sceneName0, int32_t ___mode1, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AsyncOperation_tD2789250E4B098DEDA92B366A577E500A92D2D3C* SceneManager_UnloadSceneAsync_mF6F4161EF48C6622AA1B5BC66B4A2CA736C4D2B2 (String_t* ___sceneName0, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Scene_tA1DC762B79745EB5140F054C884855B922318356 SceneManager_GetActiveScene_m0B320EC4302F51A71495D1CCD1A0FF9C2ED1FDC8 (const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Scene_get_name_m3C818DFA663E159274DAD823B780C7616C5E2A8C (Scene_tA1DC762B79745EB5140F054C884855B922318356* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2 (RuntimeObject* __this, const RuntimeMethod* method) ;
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float Mathf_Max_mF5379E63D2BBAC76D090748695D833934F8AD051_inline (float ___a0, float ___b1, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Time_set_timeScale_mEF84EE4B2376A458387648079B426B267862D331 (float ___value0, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Time_get_timeScale_m1F45A413D4EEA08B1E0988022512C137F6C1E616 (const RuntimeMethod* method) ;
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SceneCommands_LoadScene_mBAA44F58BB3F283CE354911CB9A48CC0B5DAA181 (String_t* ___sceneName0, const RuntimeMethod* method) 
{
	{
		String_t* L_0 = ___sceneName0;
		SceneCommands_LoadSceneInternal_m44750C6CBF099D1649D013DE26C8E6C838AA234B(L_0, (bool)0, 0, NULL);
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SceneCommands_LoadScene_m982EF65D399214FE381233249AE819994B2CAE0E (String_t* ___sceneName0, int32_t ___mode1, const RuntimeMethod* method) 
{
	{
		String_t* L_0 = ___sceneName0;
		int32_t L_1 = ___mode1;
		SceneCommands_LoadSceneInternal_m44750C6CBF099D1649D013DE26C8E6C838AA234B(L_0, (bool)0, L_1, NULL);
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SceneCommands_LoadSceneAsync_m4117C64FD6C4645BFA744E942718E5B277602473 (String_t* ___sceneName0, const RuntimeMethod* method) 
{
	{
		String_t* L_0 = ___sceneName0;
		SceneCommands_LoadSceneInternal_m44750C6CBF099D1649D013DE26C8E6C838AA234B(L_0, (bool)1, 0, NULL);
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SceneCommands_LoadSceneAsync_mC5B1FC860523EA817017662F94663E7DEA31EF38 (String_t* ___sceneName0, int32_t ___mode1, const RuntimeMethod* method) 
{
	{
		String_t* L_0 = ___sceneName0;
		int32_t L_1 = ___mode1;
		SceneCommands_LoadSceneInternal_m44750C6CBF099D1649D013DE26C8E6C838AA234B(L_0, (bool)1, L_1, NULL);
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SceneCommands_LoadSceneInternal_m44750C6CBF099D1649D013DE26C8E6C838AA234B (String_t* ___sceneName0, bool ___isAsync1, int32_t ___mode2, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SceneManager_tA0EF56A88ACA4A15731AF7FDC10A869FA4C698FA_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral14EFC2C6E9EEDD3D7AD722A958977C463EF508F0);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral813C79655CE3ED707AE14612C0DEA0D767D00F51);
		s_Il2CppMethodInitialized = true;
	}
	Scene_tA1DC762B79745EB5140F054C884855B922318356 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		String_t* L_0 = ___sceneName0;
		il2cpp_codegen_runtime_class_init_inline(SceneManager_tA0EF56A88ACA4A15731AF7FDC10A869FA4C698FA_il2cpp_TypeInfo_var);
		Scene_tA1DC762B79745EB5140F054C884855B922318356 L_1;
		L_1 = SceneManager_GetSceneByName_m2A70CB2D1C586ED6747E82693785CA86F99FA9B9(L_0, NULL);
		V_0 = L_1;
		bool L_2;
		L_2 = Scene_IsValid_m0D5200731D3E26ECBBB55803F9242965A14A4599((&V_0), NULL);
		if (!L_2)
		{
			goto IL_0026;
		}
	}
	{
		String_t* L_3 = ___sceneName0;
		String_t* L_4;
		L_4 = String_Concat_m8855A6DE10F84DA7F4EC113CADDB59873A25573B(_stringLiteral813C79655CE3ED707AE14612C0DEA0D767D00F51, L_3, _stringLiteral14EFC2C6E9EEDD3D7AD722A958977C463EF508F0, NULL);
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_Log_m87A9A3C761FF5C43ED8A53B16190A53D08F818BB(L_4, NULL);
		return;
	}

IL_0026:
	{
		bool L_5 = ___isAsync1;
		if (!L_5)
		{
			goto IL_0032;
		}
	}
	{
		String_t* L_6 = ___sceneName0;
		int32_t L_7 = ___mode2;
		il2cpp_codegen_runtime_class_init_inline(SceneManager_tA0EF56A88ACA4A15731AF7FDC10A869FA4C698FA_il2cpp_TypeInfo_var);
		AsyncOperation_tD2789250E4B098DEDA92B366A577E500A92D2D3C* L_8;
		L_8 = SceneManager_LoadSceneAsync_m29D55D2C6CB7A019B26DA3F44C0881FF6AC491EC(L_6, L_7, NULL);
		return;
	}

IL_0032:
	{
		String_t* L_9 = ___sceneName0;
		int32_t L_10 = ___mode2;
		il2cpp_codegen_runtime_class_init_inline(SceneManager_tA0EF56A88ACA4A15731AF7FDC10A869FA4C698FA_il2cpp_TypeInfo_var);
		SceneManager_LoadScene_m2841705C02C450E42A44B5EEE2A6A2C4261FA3AF(L_9, L_10, NULL);
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SceneCommands_UnloadScene_m9436ABF65783D1BF8594C211C75FDBD0865CF111 (String_t* ___sceneName0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SceneManager_tA0EF56A88ACA4A15731AF7FDC10A869FA4C698FA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ___sceneName0;
		il2cpp_codegen_runtime_class_init_inline(SceneManager_tA0EF56A88ACA4A15731AF7FDC10A869FA4C698FA_il2cpp_TypeInfo_var);
		AsyncOperation_tD2789250E4B098DEDA92B366A577E500A92D2D3C* L_1;
		L_1 = SceneManager_UnloadSceneAsync_mF6F4161EF48C6622AA1B5BC66B4A2CA736C4D2B2(L_0, NULL);
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SceneCommands_RestartScene_m8B8CE9CE5F643ED7D517B7AD996328429C0ADBCF (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SceneManager_tA0EF56A88ACA4A15731AF7FDC10A869FA4C698FA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Scene_tA1DC762B79745EB5140F054C884855B922318356 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		il2cpp_codegen_runtime_class_init_inline(SceneManager_tA0EF56A88ACA4A15731AF7FDC10A869FA4C698FA_il2cpp_TypeInfo_var);
		Scene_tA1DC762B79745EB5140F054C884855B922318356 L_0;
		L_0 = SceneManager_GetActiveScene_m0B320EC4302F51A71495D1CCD1A0FF9C2ED1FDC8(NULL);
		V_0 = L_0;
		String_t* L_1;
		L_1 = Scene_get_name_m3C818DFA663E159274DAD823B780C7616C5E2A8C((&V_0), NULL);
		SceneManager_LoadScene_m2841705C02C450E42A44B5EEE2A6A2C4261FA3AF(L_1, 0, NULL);
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SceneCommands__ctor_m57CAC8925D540A6EA5DEE203881210F5C935906B (SceneCommands_tD919696B0B3F4F289ECA77E9E677A51579914472* __this, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TimeCommands_SetTimeScale_m24F47A0EF5EF561DDBE978F16B3E787FF5FCBE1A (float ___value0, const RuntimeMethod* method) 
{
	{
		float L_0 = ___value0;
		float L_1;
		L_1 = Mathf_Max_mF5379E63D2BBAC76D090748695D833934F8AD051_inline(L_0, (0.0f), NULL);
		Time_set_timeScale_mEF84EE4B2376A458387648079B426B267862D331(L_1, NULL);
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float TimeCommands_GetTimeScale_mB93AE87BA0BCB1562443FCD021301FE0FCFC971B (const RuntimeMethod* method) 
{
	{
		float L_0;
		L_0 = Time_get_timeScale_m1F45A413D4EEA08B1E0988022512C137F6C1E616(NULL);
		return L_0;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TimeCommands__ctor_m14FCEFDFEC4473F6F5DD7CBEE28B382E495F1534 (TimeCommands_t6DE00ACD4923F4291E15DF7C6CE0C4F9FE100901* __this, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float Mathf_Max_mF5379E63D2BBAC76D090748695D833934F8AD051_inline (float ___a0, float ___b1, const RuntimeMethod* method) 
{
	float V_0 = 0.0f;
	float G_B3_0 = 0.0f;
	{
		float L_0 = ___a0;
		float L_1 = ___b1;
		if ((((float)L_0) > ((float)L_1)))
		{
			goto IL_0008;
		}
	}
	{
		float L_2 = ___b1;
		G_B3_0 = L_2;
		goto IL_0009;
	}

IL_0008:
	{
		float L_3 = ___a0;
		G_B3_0 = L_3;
	}

IL_0009:
	{
		V_0 = G_B3_0;
		goto IL_000c;
	}

IL_000c:
	{
		float L_4 = V_0;
		return L_4;
	}
}
