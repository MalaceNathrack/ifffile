// Decompiled with JetBrains decompiler
// Type: LibSWBDotNet.LuaConfig
// Assembly: LibSWBInterop, Version=1.0.6184.236, Culture=neutral, PublicKeyToken=null
// MVID: B8F9312C-845E-42D3-9114-F2250FC92114
// Assembly location: C:\MyStarWarsGalaxies\sytner\LibSWBInterop.dll

using Jodel;
using std;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace LibSWBDotNet
{
  public class LuaConfig
  {
    public static unsafe string GetPath(string id)
    {
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar1;
      \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar1, &id);
      string path;
      // ISSUE: fault handler
      try
      {
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar2;
        \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bctor\u007D(&stdAllocatorChar2, (sbyte*) &\u003CModule\u003E.\u003F\u003F_C\u0040_00CNPNBAHC\u0040\u003F\u0024AA\u0040);
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar3;
        // ISSUE: fault handler
        try
        {
          global::LuaConfig luaConfig;
          global::LuaConfig* settingsLua = \u003CModule\u003E.GetSettingsLua(&luaConfig);
          // ISSUE: fault handler
          try
          {
            LuaTableNode luaTableNode1;
            LuaTableNode* luaTableNodePtr1 = \u003CModule\u003E.LuaConfig\u002E\u005B\u005D(settingsLua, &luaTableNode1, (sbyte*) &\u003CModule\u003E.\u003F\u003F_C\u0040_04NGEJNKEG\u0040Base\u003F\u0024AA\u0040);
            // ISSUE: fault handler
            try
            {
              LuaTableNode luaTableNode2;
              LuaTableNode* luaTableNodePtr2 = \u003CModule\u003E.LuaTableNode\u002E\u005B\u005D(luaTableNodePtr1, &luaTableNode2, (sbyte*) &\u003CModule\u003E.\u003F\u003F_C\u0040_05EAGKIPDA\u0040Paths\u003F\u0024AA\u0040);
              // ISSUE: fault handler
              try
              {
                LuaTableNode luaTableNode3;
                LuaTableNode* luaTableNodePtr3 = \u003CModule\u003E.LuaTableNode\u002E\u005B\u005D(luaTableNodePtr2, &luaTableNode3, (sbyte*) &\u003CModule\u003E.\u003F\u003F_C\u0040_04BHIIPFEC\u0040base\u003F\u0024AA\u0040);
                // ISSUE: fault handler
                try
                {
                  \u003CModule\u003E.LuaTableNode\u002EgetDefault\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E(luaTableNodePtr3, &stdAllocatorChar3, &stdAllocatorChar2);
                }
                __fault
                {
                  // ISSUE: method pointer
                  // ISSUE: cast to a function pointer type
                  \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(LuaTableNode\u002E\u007Bdtor\u007D), (void*) &luaTableNode3);
                }
                // ISSUE: fault handler
                try
                {
                  \u003CModule\u003E.LuaTableNode\u002E\u007Bdtor\u007D(&luaTableNode3);
                }
                __fault
                {
                  // ISSUE: method pointer
                  // ISSUE: cast to a function pointer type
                  \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar3);
                }
              }
              __fault
              {
                // ISSUE: method pointer
                // ISSUE: cast to a function pointer type
                \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(LuaTableNode\u002E\u007Bdtor\u007D), (void*) &luaTableNode2);
              }
              // ISSUE: fault handler
              try
              {
                \u003CModule\u003E.LuaTableNode\u002E\u007Bdtor\u007D(&luaTableNode2);
              }
              __fault
              {
                // ISSUE: method pointer
                // ISSUE: cast to a function pointer type
                \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar3);
              }
            }
            __fault
            {
              // ISSUE: method pointer
              // ISSUE: cast to a function pointer type
              \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(LuaTableNode\u002E\u007Bdtor\u007D), (void*) &luaTableNode1);
            }
            // ISSUE: fault handler
            try
            {
              \u003CModule\u003E.LuaTableNode\u002E\u007Bdtor\u007D(&luaTableNode1);
            }
            __fault
            {
              // ISSUE: method pointer
              // ISSUE: cast to a function pointer type
              \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar3);
            }
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(LuaConfig\u002E\u007Bdtor\u007D), (void*) &luaConfig);
          }
          // ISSUE: fault handler
          try
          {
            \u003CModule\u003E.LuaConfig\u002E\u007Bdtor\u007D(&luaConfig);
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar3);
          }
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
        }
        // ISSUE: fault handler
        try
        {
          \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar2);
          if (id != "base")
          {
            basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar4;
            \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bctor\u007D(&stdAllocatorChar4, (sbyte*) &\u003CModule\u003E.\u003F\u003F_C\u0040_00CNPNBAHC\u0040\u003F\u0024AA\u0040);
            // ISSUE: fault handler
            try
            {
              global::LuaConfig luaConfig;
              global::LuaConfig* settingsLua = \u003CModule\u003E.GetSettingsLua(&luaConfig);
              // ISSUE: fault handler
              try
              {
                LuaTableNode luaTableNode4;
                LuaTableNode* luaTableNodePtr4 = \u003CModule\u003E.LuaConfig\u002E\u005B\u005D(settingsLua, &luaTableNode4, (sbyte*) &\u003CModule\u003E.\u003F\u003F_C\u0040_04NGEJNKEG\u0040Base\u003F\u0024AA\u0040);
                // ISSUE: fault handler
                try
                {
                  LuaTableNode luaTableNode5;
                  LuaTableNode* luaTableNodePtr5 = \u003CModule\u003E.LuaTableNode\u002E\u005B\u005D(luaTableNodePtr4, &luaTableNode5, (sbyte*) &\u003CModule\u003E.\u003F\u003F_C\u0040_05EAGKIPDA\u0040Paths\u003F\u0024AA\u0040);
                  // ISSUE: fault handler
                  try
                  {
                    LuaTableNode luaTableNode6;
                    LuaTableNode* luaTableNodePtr6 = \u003CModule\u003E.LuaTableNode\u002E\u005B\u005D(luaTableNodePtr5, &luaTableNode6, \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Ec_str(&stdAllocatorChar1));
                    // ISSUE: fault handler
                    try
                    {
                      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar5;
                      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* stdAllocatorChar6 = \u003CModule\u003E.LuaTableNode\u002EgetDefault\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E(luaTableNodePtr6, &stdAllocatorChar5, &stdAllocatorChar4);
                      // ISSUE: fault handler
                      try
                      {
                        \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u002B\u003D(&stdAllocatorChar3, stdAllocatorChar6);
                      }
                      __fault
                      {
                        // ISSUE: method pointer
                        // ISSUE: cast to a function pointer type
                        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar5);
                      }
                      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar5);
                    }
                    __fault
                    {
                      // ISSUE: method pointer
                      // ISSUE: cast to a function pointer type
                      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(LuaTableNode\u002E\u007Bdtor\u007D), (void*) &luaTableNode6);
                    }
                    \u003CModule\u003E.LuaTableNode\u002E\u007Bdtor\u007D(&luaTableNode6);
                  }
                  __fault
                  {
                    // ISSUE: method pointer
                    // ISSUE: cast to a function pointer type
                    \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(LuaTableNode\u002E\u007Bdtor\u007D), (void*) &luaTableNode5);
                  }
                  \u003CModule\u003E.LuaTableNode\u002E\u007Bdtor\u007D(&luaTableNode5);
                }
                __fault
                {
                  // ISSUE: method pointer
                  // ISSUE: cast to a function pointer type
                  \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(LuaTableNode\u002E\u007Bdtor\u007D), (void*) &luaTableNode4);
                }
                \u003CModule\u003E.LuaTableNode\u002E\u007Bdtor\u007D(&luaTableNode4);
              }
              __fault
              {
                // ISSUE: method pointer
                // ISSUE: cast to a function pointer type
                \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(LuaConfig\u002E\u007Bdtor\u007D), (void*) &luaConfig);
              }
              \u003CModule\u003E.LuaConfig\u002E\u007Bdtor\u007D(&luaConfig);
            }
            __fault
            {
              // ISSUE: method pointer
              // ISSUE: cast to a function pointer type
              \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar4);
            }
            \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar4);
          }
          path = new string(\u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Ec_str(&stdAllocatorChar3));
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar3);
        }
        \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar3);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
      }
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar1);
      return path;
    }

    [return: MarshalAs(UnmanagedType.U1)]
    public static unsafe bool GetOptionBool(string root, string name)
    {
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar1;
      \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar1, &root);
      bool defaultBool;
      // ISSUE: fault handler
      try
      {
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar2;
        \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar2, &name);
        // ISSUE: fault handler
        try
        {
          bool flag = false;
          global::LuaConfig luaConfig;
          global::LuaConfig* settingsLua = \u003CModule\u003E.GetSettingsLua(&luaConfig);
          // ISSUE: fault handler
          try
          {
            LuaTableNode luaTableNode1;
            LuaTableNode* luaTableNodePtr1 = \u003CModule\u003E.LuaConfig\u002E\u005B\u005D(settingsLua, &luaTableNode1, \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Ec_str(&stdAllocatorChar1));
            // ISSUE: fault handler
            try
            {
              LuaTableNode luaTableNode2;
              LuaTableNode* luaTableNodePtr2 = \u003CModule\u003E.LuaTableNode\u002E\u005B\u005D(luaTableNodePtr1, &luaTableNode2, \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Ec_str(&stdAllocatorChar2));
              // ISSUE: fault handler
              try
              {
                defaultBool = \u003CModule\u003E.LuaTableNode\u002EgetDefault\u003Cbool\u003E(luaTableNodePtr2, &flag);
              }
              __fault
              {
                // ISSUE: method pointer
                // ISSUE: cast to a function pointer type
                \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(LuaTableNode\u002E\u007Bdtor\u007D), (void*) &luaTableNode2);
              }
              \u003CModule\u003E.LuaTableNode\u002E\u007Bdtor\u007D(&luaTableNode2);
            }
            __fault
            {
              // ISSUE: method pointer
              // ISSUE: cast to a function pointer type
              \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(LuaTableNode\u002E\u007Bdtor\u007D), (void*) &luaTableNode1);
            }
            \u003CModule\u003E.LuaTableNode\u002E\u007Bdtor\u007D(&luaTableNode1);
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(LuaConfig\u002E\u007Bdtor\u007D), (void*) &luaConfig);
          }
          \u003CModule\u003E.LuaConfig\u002E\u007Bdtor\u007D(&luaConfig);
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
        }
        \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar2);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
      }
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar1);
      return defaultBool;
    }

    public static unsafe int GetOptionInt(string root, string name)
    {
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar1;
      \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar1, &root);
      int defaultInt;
      // ISSUE: fault handler
      try
      {
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar2;
        \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar2, &name);
        // ISSUE: fault handler
        try
        {
          int num = 0;
          global::LuaConfig luaConfig;
          global::LuaConfig* settingsLua = \u003CModule\u003E.GetSettingsLua(&luaConfig);
          // ISSUE: fault handler
          try
          {
            LuaTableNode luaTableNode1;
            LuaTableNode* luaTableNodePtr1 = \u003CModule\u003E.LuaConfig\u002E\u005B\u005D(settingsLua, &luaTableNode1, \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Ec_str(&stdAllocatorChar1));
            // ISSUE: fault handler
            try
            {
              LuaTableNode luaTableNode2;
              LuaTableNode* luaTableNodePtr2 = \u003CModule\u003E.LuaTableNode\u002E\u005B\u005D(luaTableNodePtr1, &luaTableNode2, \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Ec_str(&stdAllocatorChar2));
              // ISSUE: fault handler
              try
              {
                defaultInt = \u003CModule\u003E.LuaTableNode\u002EgetDefault\u003Cint\u003E(luaTableNodePtr2, &num);
              }
              __fault
              {
                // ISSUE: method pointer
                // ISSUE: cast to a function pointer type
                \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(LuaTableNode\u002E\u007Bdtor\u007D), (void*) &luaTableNode2);
              }
              \u003CModule\u003E.LuaTableNode\u002E\u007Bdtor\u007D(&luaTableNode2);
            }
            __fault
            {
              // ISSUE: method pointer
              // ISSUE: cast to a function pointer type
              \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(LuaTableNode\u002E\u007Bdtor\u007D), (void*) &luaTableNode1);
            }
            \u003CModule\u003E.LuaTableNode\u002E\u007Bdtor\u007D(&luaTableNode1);
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(LuaConfig\u002E\u007Bdtor\u007D), (void*) &luaConfig);
          }
          \u003CModule\u003E.LuaConfig\u002E\u007Bdtor\u007D(&luaConfig);
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
        }
        \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar2);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
      }
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar1);
      return defaultInt;
    }

    public static unsafe float GetOptionFloat(string root, string name)
    {
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar1;
      \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar1, &root);
      float defaultFloat;
      // ISSUE: fault handler
      try
      {
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar2;
        \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar2, &name);
        // ISSUE: fault handler
        try
        {
          float num = 0.0f;
          global::LuaConfig luaConfig;
          global::LuaConfig* settingsLua = \u003CModule\u003E.GetSettingsLua(&luaConfig);
          // ISSUE: fault handler
          try
          {
            LuaTableNode luaTableNode1;
            LuaTableNode* luaTableNodePtr1 = \u003CModule\u003E.LuaConfig\u002E\u005B\u005D(settingsLua, &luaTableNode1, \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Ec_str(&stdAllocatorChar1));
            // ISSUE: fault handler
            try
            {
              LuaTableNode luaTableNode2;
              LuaTableNode* luaTableNodePtr2 = \u003CModule\u003E.LuaTableNode\u002E\u005B\u005D(luaTableNodePtr1, &luaTableNode2, \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Ec_str(&stdAllocatorChar2));
              // ISSUE: fault handler
              try
              {
                defaultFloat = \u003CModule\u003E.LuaTableNode\u002EgetDefault\u003Cfloat\u003E(luaTableNodePtr2, &num);
              }
              __fault
              {
                // ISSUE: method pointer
                // ISSUE: cast to a function pointer type
                \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(LuaTableNode\u002E\u007Bdtor\u007D), (void*) &luaTableNode2);
              }
              \u003CModule\u003E.LuaTableNode\u002E\u007Bdtor\u007D(&luaTableNode2);
            }
            __fault
            {
              // ISSUE: method pointer
              // ISSUE: cast to a function pointer type
              \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(LuaTableNode\u002E\u007Bdtor\u007D), (void*) &luaTableNode1);
            }
            \u003CModule\u003E.LuaTableNode\u002E\u007Bdtor\u007D(&luaTableNode1);
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(LuaConfig\u002E\u007Bdtor\u007D), (void*) &luaConfig);
          }
          \u003CModule\u003E.LuaConfig\u002E\u007Bdtor\u007D(&luaConfig);
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
        }
        \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar2);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
      }
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar1);
      return defaultFloat;
    }

    public static unsafe string GetOptionString(string root, string name)
    {
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar1;
      \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar1, &root);
      string optionString;
      // ISSUE: fault handler
      try
      {
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar2;
        \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar2, &name);
        // ISSUE: fault handler
        try
        {
          basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar3;
          \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bctor\u007D(&stdAllocatorChar3, (sbyte*) &\u003CModule\u003E.\u003F\u003F_C\u0040_00CNPNBAHC\u0040\u003F\u0024AA\u0040);
          basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar4;
          // ISSUE: fault handler
          try
          {
            global::LuaConfig luaConfig;
            global::LuaConfig* settingsLua = \u003CModule\u003E.GetSettingsLua(&luaConfig);
            // ISSUE: fault handler
            try
            {
              LuaTableNode luaTableNode1;
              LuaTableNode* luaTableNodePtr1 = \u003CModule\u003E.LuaConfig\u002E\u005B\u005D(settingsLua, &luaTableNode1, \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Ec_str(&stdAllocatorChar1));
              // ISSUE: fault handler
              try
              {
                LuaTableNode luaTableNode2;
                LuaTableNode* luaTableNodePtr2 = \u003CModule\u003E.LuaTableNode\u002E\u005B\u005D(luaTableNodePtr1, &luaTableNode2, \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Ec_str(&stdAllocatorChar2));
                // ISSUE: fault handler
                try
                {
                  \u003CModule\u003E.LuaTableNode\u002EgetDefault\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E(luaTableNodePtr2, &stdAllocatorChar4, &stdAllocatorChar3);
                }
                __fault
                {
                  // ISSUE: method pointer
                  // ISSUE: cast to a function pointer type
                  \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(LuaTableNode\u002E\u007Bdtor\u007D), (void*) &luaTableNode2);
                }
                // ISSUE: fault handler
                try
                {
                  \u003CModule\u003E.LuaTableNode\u002E\u007Bdtor\u007D(&luaTableNode2);
                }
                __fault
                {
                  // ISSUE: method pointer
                  // ISSUE: cast to a function pointer type
                  \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar4);
                }
              }
              __fault
              {
                // ISSUE: method pointer
                // ISSUE: cast to a function pointer type
                \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(LuaTableNode\u002E\u007Bdtor\u007D), (void*) &luaTableNode1);
              }
              // ISSUE: fault handler
              try
              {
                \u003CModule\u003E.LuaTableNode\u002E\u007Bdtor\u007D(&luaTableNode1);
              }
              __fault
              {
                // ISSUE: method pointer
                // ISSUE: cast to a function pointer type
                \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar4);
              }
            }
            __fault
            {
              // ISSUE: method pointer
              // ISSUE: cast to a function pointer type
              \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(LuaConfig\u002E\u007Bdtor\u007D), (void*) &luaConfig);
            }
            // ISSUE: fault handler
            try
            {
              \u003CModule\u003E.LuaConfig\u002E\u007Bdtor\u007D(&luaConfig);
            }
            __fault
            {
              // ISSUE: method pointer
              // ISSUE: cast to a function pointer type
              \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar4);
            }
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar3);
          }
          // ISSUE: fault handler
          try
          {
            \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar3);
            optionString = new string(\u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Ec_str(&stdAllocatorChar4));
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar4);
          }
          \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar4);
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
        }
        \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar2);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
      }
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar1);
      return optionString;
    }

    public static unsafe Tuple<float, float> GetOptionVector2(string root, string name)
    {
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar1;
      \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar1, &root);
      Tuple<float, float> optionVector2;
      // ISSUE: fault handler
      try
      {
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar2;
        \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar2, &name);
        // ISSUE: fault handler
        try
        {
          Vector2 vector2_1;
          \u003CModule\u003E.Jodel\u002EVector2\u002E\u007Bctor\u007D(&vector2_1, 0.0f, 0.0f);
          global::LuaConfig luaConfig;
          global::LuaConfig* settingsLua = \u003CModule\u003E.GetSettingsLua(&luaConfig);
          Vector2 vector2_2;
          // ISSUE: fault handler
          try
          {
            LuaTableNode luaTableNode1;
            LuaTableNode* luaTableNodePtr1 = \u003CModule\u003E.LuaConfig\u002E\u005B\u005D(settingsLua, &luaTableNode1, \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Ec_str(&stdAllocatorChar1));
            // ISSUE: fault handler
            try
            {
              LuaTableNode luaTableNode2;
              LuaTableNode* luaTableNodePtr2 = \u003CModule\u003E.LuaTableNode\u002E\u005B\u005D(luaTableNodePtr1, &luaTableNode2, \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Ec_str(&stdAllocatorChar2));
              // ISSUE: fault handler
              try
              {
                \u003CModule\u003E.LuaTableNode\u002EgetDefault\u003Cstruct\u0020Jodel\u003A\u003AVector2\u003E(luaTableNodePtr2, &vector2_2, &vector2_1);
              }
              __fault
              {
                // ISSUE: method pointer
                // ISSUE: cast to a function pointer type
                \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(LuaTableNode\u002E\u007Bdtor\u007D), (void*) &luaTableNode2);
              }
              \u003CModule\u003E.LuaTableNode\u002E\u007Bdtor\u007D(&luaTableNode2);
            }
            __fault
            {
              // ISSUE: method pointer
              // ISSUE: cast to a function pointer type
              \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(LuaTableNode\u002E\u007Bdtor\u007D), (void*) &luaTableNode1);
            }
            \u003CModule\u003E.LuaTableNode\u002E\u007Bdtor\u007D(&luaTableNode1);
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(LuaConfig\u002E\u007Bdtor\u007D), (void*) &luaConfig);
          }
          \u003CModule\u003E.LuaConfig\u002E\u007Bdtor\u007D(&luaConfig);
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          optionVector2 = new Tuple<float, float>(^(float&) ref vector2_2, ^(float&) ((IntPtr) &vector2_2 + 4));
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
        }
        \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar2);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
      }
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar1);
      return optionVector2;
    }

    public static unsafe Tuple<float, float, float> GetOptionVector3(string root, string name)
    {
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar1;
      \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar1, &root);
      Tuple<float, float, float> optionVector3;
      // ISSUE: fault handler
      try
      {
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar2;
        \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar2, &name);
        // ISSUE: fault handler
        try
        {
          Vector3 vector3_1;
          \u003CModule\u003E.Jodel\u002EVector3\u002E\u007Bctor\u007D(&vector3_1, 0.0f, 0.0f, 0.0f);
          global::LuaConfig luaConfig;
          global::LuaConfig* settingsLua = \u003CModule\u003E.GetSettingsLua(&luaConfig);
          Vector3 vector3_2;
          // ISSUE: fault handler
          try
          {
            LuaTableNode luaTableNode1;
            LuaTableNode* luaTableNodePtr1 = \u003CModule\u003E.LuaConfig\u002E\u005B\u005D(settingsLua, &luaTableNode1, \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Ec_str(&stdAllocatorChar1));
            // ISSUE: fault handler
            try
            {
              LuaTableNode luaTableNode2;
              LuaTableNode* luaTableNodePtr2 = \u003CModule\u003E.LuaTableNode\u002E\u005B\u005D(luaTableNodePtr1, &luaTableNode2, \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Ec_str(&stdAllocatorChar2));
              // ISSUE: fault handler
              try
              {
                \u003CModule\u003E.LuaTableNode\u002EgetDefault\u003Cstruct\u0020Jodel\u003A\u003AVector3\u003E(luaTableNodePtr2, &vector3_2, &vector3_1);
              }
              __fault
              {
                // ISSUE: method pointer
                // ISSUE: cast to a function pointer type
                \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(LuaTableNode\u002E\u007Bdtor\u007D), (void*) &luaTableNode2);
              }
              \u003CModule\u003E.LuaTableNode\u002E\u007Bdtor\u007D(&luaTableNode2);
            }
            __fault
            {
              // ISSUE: method pointer
              // ISSUE: cast to a function pointer type
              \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(LuaTableNode\u002E\u007Bdtor\u007D), (void*) &luaTableNode1);
            }
            \u003CModule\u003E.LuaTableNode\u002E\u007Bdtor\u007D(&luaTableNode1);
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(LuaConfig\u002E\u007Bdtor\u007D), (void*) &luaConfig);
          }
          \u003CModule\u003E.LuaConfig\u002E\u007Bdtor\u007D(&luaConfig);
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          optionVector3 = new Tuple<float, float, float>(^(float&) ref vector3_2, ^(float&) ((IntPtr) &vector3_2 + 4), ^(float&) ((IntPtr) &vector3_2 + 8));
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
        }
        \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar2);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
      }
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar1);
      return optionVector3;
    }

    public static unsafe Tuple<float, float, float, float> GetOptionVector4(
      string root,
      string name)
    {
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar1;
      \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar1, &root);
      Tuple<float, float, float, float> optionVector4;
      // ISSUE: fault handler
      try
      {
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar2;
        \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar2, &name);
        // ISSUE: fault handler
        try
        {
          Vector4 vector4_1;
          \u003CModule\u003E.Jodel\u002EVector4\u002E\u007Bctor\u007D(&vector4_1, 0.0f, 0.0f, 0.0f, 0.0f);
          global::LuaConfig luaConfig;
          global::LuaConfig* settingsLua = \u003CModule\u003E.GetSettingsLua(&luaConfig);
          Vector4 vector4_2;
          // ISSUE: fault handler
          try
          {
            LuaTableNode luaTableNode1;
            LuaTableNode* luaTableNodePtr1 = \u003CModule\u003E.LuaConfig\u002E\u005B\u005D(settingsLua, &luaTableNode1, \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Ec_str(&stdAllocatorChar1));
            // ISSUE: fault handler
            try
            {
              LuaTableNode luaTableNode2;
              LuaTableNode* luaTableNodePtr2 = \u003CModule\u003E.LuaTableNode\u002E\u005B\u005D(luaTableNodePtr1, &luaTableNode2, \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Ec_str(&stdAllocatorChar2));
              // ISSUE: fault handler
              try
              {
                \u003CModule\u003E.LuaTableNode\u002EgetDefault\u003Cstruct\u0020Jodel\u003A\u003AVector4\u003E(luaTableNodePtr2, &vector4_2, &vector4_1);
              }
              __fault
              {
                // ISSUE: method pointer
                // ISSUE: cast to a function pointer type
                \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(LuaTableNode\u002E\u007Bdtor\u007D), (void*) &luaTableNode2);
              }
              \u003CModule\u003E.LuaTableNode\u002E\u007Bdtor\u007D(&luaTableNode2);
            }
            __fault
            {
              // ISSUE: method pointer
              // ISSUE: cast to a function pointer type
              \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(LuaTableNode\u002E\u007Bdtor\u007D), (void*) &luaTableNode1);
            }
            \u003CModule\u003E.LuaTableNode\u002E\u007Bdtor\u007D(&luaTableNode1);
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(LuaConfig\u002E\u007Bdtor\u007D), (void*) &luaConfig);
          }
          \u003CModule\u003E.LuaConfig\u002E\u007Bdtor\u007D(&luaConfig);
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          optionVector4 = new Tuple<float, float, float, float>(^(float&) ref vector4_2, ^(float&) ((IntPtr) &vector4_2 + 4), ^(float&) ((IntPtr) &vector4_2 + 8), ^(float&) ((IntPtr) &vector4_2 + 12));
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
        }
        \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar2);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
      }
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar1);
      return optionVector4;
    }

    public static unsafe Tuple<int, int> GetOptionIntVector2(string root, string name)
    {
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar1;
      \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar1, &root);
      Tuple<int, int> optionIntVector2;
      // ISSUE: fault handler
      try
      {
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar2;
        \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar2, &name);
        // ISSUE: fault handler
        try
        {
          Vector2 vector2_1;
          \u003CModule\u003E.Jodel\u002EVector2\u002E\u007Bctor\u007D(&vector2_1, 0.0f, 0.0f);
          global::LuaConfig luaConfig;
          global::LuaConfig* settingsLua = \u003CModule\u003E.GetSettingsLua(&luaConfig);
          Vector2 vector2_2;
          // ISSUE: fault handler
          try
          {
            LuaTableNode luaTableNode1;
            LuaTableNode* luaTableNodePtr1 = \u003CModule\u003E.LuaConfig\u002E\u005B\u005D(settingsLua, &luaTableNode1, \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Ec_str(&stdAllocatorChar1));
            // ISSUE: fault handler
            try
            {
              LuaTableNode luaTableNode2;
              LuaTableNode* luaTableNodePtr2 = \u003CModule\u003E.LuaTableNode\u002E\u005B\u005D(luaTableNodePtr1, &luaTableNode2, \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Ec_str(&stdAllocatorChar2));
              // ISSUE: fault handler
              try
              {
                \u003CModule\u003E.LuaTableNode\u002EgetDefault\u003Cstruct\u0020Jodel\u003A\u003AVector2\u003E(luaTableNodePtr2, &vector2_2, &vector2_1);
              }
              __fault
              {
                // ISSUE: method pointer
                // ISSUE: cast to a function pointer type
                \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(LuaTableNode\u002E\u007Bdtor\u007D), (void*) &luaTableNode2);
              }
              \u003CModule\u003E.LuaTableNode\u002E\u007Bdtor\u007D(&luaTableNode2);
            }
            __fault
            {
              // ISSUE: method pointer
              // ISSUE: cast to a function pointer type
              \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(LuaTableNode\u002E\u007Bdtor\u007D), (void*) &luaTableNode1);
            }
            \u003CModule\u003E.LuaTableNode\u002E\u007Bdtor\u007D(&luaTableNode1);
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(LuaConfig\u002E\u007Bdtor\u007D), (void*) &luaConfig);
          }
          \u003CModule\u003E.LuaConfig\u002E\u007Bdtor\u007D(&luaConfig);
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          optionIntVector2 = new Tuple<int, int>((int) ^(float&) ref vector2_2, (int) ^(float&) ((IntPtr) &vector2_2 + 4));
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
        }
        \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar2);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
      }
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar1);
      return optionIntVector2;
    }

    public static unsafe Tuple<int, int, int> GetOptionIntVector3(string root, string name)
    {
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar1;
      \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar1, &root);
      Tuple<int, int, int> optionIntVector3;
      // ISSUE: fault handler
      try
      {
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar2;
        \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar2, &name);
        // ISSUE: fault handler
        try
        {
          Vector3 vector3_1;
          \u003CModule\u003E.Jodel\u002EVector3\u002E\u007Bctor\u007D(&vector3_1, 0.0f, 0.0f, 0.0f);
          global::LuaConfig luaConfig;
          global::LuaConfig* settingsLua = \u003CModule\u003E.GetSettingsLua(&luaConfig);
          Vector3 vector3_2;
          // ISSUE: fault handler
          try
          {
            LuaTableNode luaTableNode1;
            LuaTableNode* luaTableNodePtr1 = \u003CModule\u003E.LuaConfig\u002E\u005B\u005D(settingsLua, &luaTableNode1, \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Ec_str(&stdAllocatorChar1));
            // ISSUE: fault handler
            try
            {
              LuaTableNode luaTableNode2;
              LuaTableNode* luaTableNodePtr2 = \u003CModule\u003E.LuaTableNode\u002E\u005B\u005D(luaTableNodePtr1, &luaTableNode2, \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Ec_str(&stdAllocatorChar2));
              // ISSUE: fault handler
              try
              {
                \u003CModule\u003E.LuaTableNode\u002EgetDefault\u003Cstruct\u0020Jodel\u003A\u003AVector3\u003E(luaTableNodePtr2, &vector3_2, &vector3_1);
              }
              __fault
              {
                // ISSUE: method pointer
                // ISSUE: cast to a function pointer type
                \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(LuaTableNode\u002E\u007Bdtor\u007D), (void*) &luaTableNode2);
              }
              \u003CModule\u003E.LuaTableNode\u002E\u007Bdtor\u007D(&luaTableNode2);
            }
            __fault
            {
              // ISSUE: method pointer
              // ISSUE: cast to a function pointer type
              \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(LuaTableNode\u002E\u007Bdtor\u007D), (void*) &luaTableNode1);
            }
            \u003CModule\u003E.LuaTableNode\u002E\u007Bdtor\u007D(&luaTableNode1);
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(LuaConfig\u002E\u007Bdtor\u007D), (void*) &luaConfig);
          }
          \u003CModule\u003E.LuaConfig\u002E\u007Bdtor\u007D(&luaConfig);
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          optionIntVector3 = new Tuple<int, int, int>((int) ^(float&) ref vector3_2, (int) ^(float&) ((IntPtr) &vector3_2 + 4), (int) ^(float&) ((IntPtr) &vector3_2 + 8));
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
        }
        \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar2);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
      }
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar1);
      return optionIntVector3;
    }

    public static unsafe Tuple<int, int, int, int> GetOptionIntVector4(string root, string name)
    {
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar1;
      \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar1, &root);
      Tuple<int, int, int, int> optionIntVector4;
      // ISSUE: fault handler
      try
      {
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar2;
        \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar2, &name);
        // ISSUE: fault handler
        try
        {
          Vector4 vector4_1;
          \u003CModule\u003E.Jodel\u002EVector4\u002E\u007Bctor\u007D(&vector4_1, 0.0f, 0.0f, 0.0f, 0.0f);
          global::LuaConfig luaConfig;
          global::LuaConfig* settingsLua = \u003CModule\u003E.GetSettingsLua(&luaConfig);
          Vector4 vector4_2;
          // ISSUE: fault handler
          try
          {
            LuaTableNode luaTableNode1;
            LuaTableNode* luaTableNodePtr1 = \u003CModule\u003E.LuaConfig\u002E\u005B\u005D(settingsLua, &luaTableNode1, \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Ec_str(&stdAllocatorChar1));
            // ISSUE: fault handler
            try
            {
              LuaTableNode luaTableNode2;
              LuaTableNode* luaTableNodePtr2 = \u003CModule\u003E.LuaTableNode\u002E\u005B\u005D(luaTableNodePtr1, &luaTableNode2, \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Ec_str(&stdAllocatorChar2));
              // ISSUE: fault handler
              try
              {
                \u003CModule\u003E.LuaTableNode\u002EgetDefault\u003Cstruct\u0020Jodel\u003A\u003AVector4\u003E(luaTableNodePtr2, &vector4_2, &vector4_1);
              }
              __fault
              {
                // ISSUE: method pointer
                // ISSUE: cast to a function pointer type
                \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(LuaTableNode\u002E\u007Bdtor\u007D), (void*) &luaTableNode2);
              }
              \u003CModule\u003E.LuaTableNode\u002E\u007Bdtor\u007D(&luaTableNode2);
            }
            __fault
            {
              // ISSUE: method pointer
              // ISSUE: cast to a function pointer type
              \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(LuaTableNode\u002E\u007Bdtor\u007D), (void*) &luaTableNode1);
            }
            \u003CModule\u003E.LuaTableNode\u002E\u007Bdtor\u007D(&luaTableNode1);
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(LuaConfig\u002E\u007Bdtor\u007D), (void*) &luaConfig);
          }
          \u003CModule\u003E.LuaConfig\u002E\u007Bdtor\u007D(&luaConfig);
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          optionIntVector4 = new Tuple<int, int, int, int>((int) ^(float&) ref vector4_2, (int) ^(float&) ((IntPtr) &vector4_2 + 4), (int) ^(float&) ((IntPtr) &vector4_2 + 8), (int) ^(float&) ((IntPtr) &vector4_2 + 12));
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
        }
        \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar2);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
      }
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar1);
      return optionIntVector4;
    }

    public static unsafe void SetOptionBool(string root, string name, [MarshalAs(UnmanagedType.U1)] bool value)
    {
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar1;
      \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar1, &root);
      // ISSUE: fault handler
      try
      {
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar2;
        \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar2, &name);
        // ISSUE: fault handler
        try
        {
          \u003CModule\u003E.\u003FA0xc03709c5\u002ESetOptionAndSave\u003Cbool\u003E(&stdAllocatorChar1, &stdAllocatorChar2, &value);
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
        }
        \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar2);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
      }
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar1);
    }

    public static unsafe void SetOptionInt(string root, string name, int value)
    {
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar1;
      \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar1, &root);
      // ISSUE: fault handler
      try
      {
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar2;
        \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar2, &name);
        // ISSUE: fault handler
        try
        {
          \u003CModule\u003E.\u003FA0xc03709c5\u002ESetOptionAndSave\u003Cint\u003E(&stdAllocatorChar1, &stdAllocatorChar2, &value);
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
        }
        \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar2);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
      }
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar1);
    }

    public static unsafe void SetOptionString(string root, string name, string value)
    {
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar1;
      \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar1, &root);
      // ISSUE: fault handler
      try
      {
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar2;
        \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar2, &name);
        // ISSUE: fault handler
        try
        {
          basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar3;
          \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar3, &value);
          // ISSUE: fault handler
          try
          {
            \u003CModule\u003E.\u003FA0xc03709c5\u002ESetOptionAndSave\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E(&stdAllocatorChar1, &stdAllocatorChar2, &stdAllocatorChar3);
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar3);
          }
          \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar3);
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
        }
        \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar2);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
      }
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar1);
    }

    public static unsafe void SetOptionVector2(string root, string name, Tuple<float, float> value)
    {
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar1;
      \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar1, &root);
      // ISSUE: fault handler
      try
      {
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar2;
        \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar2, &name);
        // ISSUE: fault handler
        try
        {
          Vector2 vector2;
          \u003CModule\u003E.\u003FA0xc03709c5\u002ESetOptionAndSave\u003Cstruct\u0020Jodel\u003A\u003AVector2\u003E(&stdAllocatorChar1, &stdAllocatorChar2, \u003CModule\u003E.Jodel\u002EVector2\u002E\u007Bctor\u007D(&vector2, value.Item1, value.Item2));
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
        }
        \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar2);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
      }
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar1);
    }

    public static unsafe void SetOptionVector3(
      string root,
      string name,
      Tuple<float, float, float> value)
    {
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar1;
      \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar1, &root);
      // ISSUE: fault handler
      try
      {
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar2;
        \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar2, &name);
        // ISSUE: fault handler
        try
        {
          Vector3 vector3;
          \u003CModule\u003E.\u003FA0xc03709c5\u002ESetOptionAndSave\u003Cstruct\u0020Jodel\u003A\u003AVector3\u003E(&stdAllocatorChar1, &stdAllocatorChar2, \u003CModule\u003E.Jodel\u002EVector3\u002E\u007Bctor\u007D(&vector3, value.Item1, value.Item2, value.Item3));
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
        }
        \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar2);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
      }
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar1);
    }

    public static unsafe void SetOptionVector4(
      string root,
      string name,
      Tuple<float, float, float, float> value)
    {
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar1;
      \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar1, &root);
      // ISSUE: fault handler
      try
      {
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar2;
        \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar2, &name);
        // ISSUE: fault handler
        try
        {
          Vector4 vector4;
          \u003CModule\u003E.\u003FA0xc03709c5\u002ESetOptionAndSave\u003Cstruct\u0020Jodel\u003A\u003AVector4\u003E(&stdAllocatorChar1, &stdAllocatorChar2, \u003CModule\u003E.Jodel\u002EVector4\u002E\u007Bctor\u007D(&vector4, value.Item1, value.Item2, value.Item3, value.Item4));
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
        }
        \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar2);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
      }
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar1);
    }

    public static unsafe void SetOptionIntVector2(string root, string name, Tuple<int, int> value)
    {
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar1;
      \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar1, &root);
      // ISSUE: fault handler
      try
      {
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar2;
        \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar2, &name);
        // ISSUE: fault handler
        try
        {
          Vector2 vector2;
          \u003CModule\u003E.\u003FA0xc03709c5\u002ESetOptionAndSave\u003Cstruct\u0020Jodel\u003A\u003AVector2\u003E(&stdAllocatorChar1, &stdAllocatorChar2, \u003CModule\u003E.Jodel\u002EVector2\u002E\u007Bctor\u007D(&vector2, (float) value.Item1, (float) value.Item2));
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
        }
        \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar2);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
      }
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar1);
    }

    public static unsafe void SetOptionIntVector3(
      string root,
      string name,
      Tuple<int, int, int> value)
    {
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar1;
      \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar1, &root);
      // ISSUE: fault handler
      try
      {
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar2;
        \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar2, &name);
        // ISSUE: fault handler
        try
        {
          Vector3 vector3;
          \u003CModule\u003E.\u003FA0xc03709c5\u002ESetOptionAndSave\u003Cstruct\u0020Jodel\u003A\u003AVector3\u003E(&stdAllocatorChar1, &stdAllocatorChar2, \u003CModule\u003E.Jodel\u002EVector3\u002E\u007Bctor\u007D(&vector3, (float) value.Item1, (float) value.Item2, (float) value.Item3));
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
        }
        \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar2);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
      }
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar1);
    }

    public static unsafe void SetOptionIntVector4(
      string root,
      string name,
      Tuple<int, int, int, int> value)
    {
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar1;
      \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar1, &root);
      // ISSUE: fault handler
      try
      {
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar2;
        \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar2, &name);
        // ISSUE: fault handler
        try
        {
          Vector4 vector4;
          \u003CModule\u003E.\u003FA0xc03709c5\u002ESetOptionAndSave\u003Cstruct\u0020Jodel\u003A\u003AVector4\u003E(&stdAllocatorChar1, &stdAllocatorChar2, \u003CModule\u003E.Jodel\u002EVector4\u002E\u007Bctor\u007D(&vector4, (float) value.Item1, (float) value.Item2, (float) value.Item3, (float) value.Item4));
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
        }
        \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar2);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
      }
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar1);
    }

    public static unsafe PrioritisedFile[] GetRepositoryTreeFiles()
    {
      basic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E stdAllocatorWcharT;
      basic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E* stdAllocatorWcharTPtr = &stdAllocatorWcharT;
      basic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E* repositoryScriptFileName = \u003CModule\u003E.CSwgRepository\u002ESConfiguation\u002EGetDefaultRepositoryScriptFileName(&stdAllocatorWcharT);
      CSwgRepository.SConfiguation sconfiguation;
      \u003CModule\u003E.CSwgRepository\u002ESConfiguation\u002E\u007Bctor\u007D(&sconfiguation, repositoryScriptFileName);
      PrioritisedFile[] repositoryTreeFiles;
      // ISSUE: fault handler
      try
      {
        repositoryTreeFiles = new PrioritisedFile[(int) \u003CModule\u003E.std\u002Evector\u003CSPrioritisedFile\u002Cstd\u003A\u003Aallocator\u003CSPrioritisedFile\u003E\u0020\u003E\u002Esize(\u003CModule\u003E.CSwgRepository\u002ESConfiguation\u002EGetFiles(&sconfiguation))];
        int index = 0;
        vector\u003CSPrioritisedFile\u002Cstd\u003A\u003Aallocator\u003CSPrioritisedFile\u003E\u0020\u003E* files = \u003CModule\u003E.CSwgRepository\u002ESConfiguation\u002EGetFiles(&sconfiguation);
        _Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CSPrioritisedFile\u003E\u0020\u003E\u0020\u003E sprioritisedFile1;
        \u003CModule\u003E.std\u002Evector\u003CSPrioritisedFile\u002Cstd\u003A\u003Aallocator\u003CSPrioritisedFile\u003E\u0020\u003E\u002Ebegin(files, &sprioritisedFile1);
        _Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CSPrioritisedFile\u003E\u0020\u003E\u0020\u003E sprioritisedFile2;
        \u003CModule\u003E.std\u002Evector\u003CSPrioritisedFile\u002Cstd\u003A\u003Aallocator\u003CSPrioritisedFile\u003E\u0020\u003E\u002Eend(files, &sprioritisedFile2);
        if (\u003CModule\u003E.std\u002E_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CSPrioritisedFile\u003E\u0020\u003E\u0020\u003E\u002E\u0021\u003D(&sprioritisedFile1, &sprioritisedFile2))
        {
          do
          {
            SPrioritisedFile* native = \u003CModule\u003E.std\u002E_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CSPrioritisedFile\u003E\u0020\u003E\u0020\u003E\u002E\u002A(&sprioritisedFile1);
            repositoryTreeFiles[index] = new PrioritisedFile(native);
            ++index;
            \u003CModule\u003E.std\u002E_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CSPrioritisedFile\u003E\u0020\u003E\u0020\u003E\u002E\u002B\u002B(&sprioritisedFile1);
          }
          while (\u003CModule\u003E.std\u002E_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CSPrioritisedFile\u003E\u0020\u003E\u0020\u003E\u002E\u0021\u003D(&sprioritisedFile1, &sprioritisedFile2));
        }
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(CSwgRepository\u002ESConfiguation\u002E\u007Bdtor\u007D), (void*) &sconfiguation);
      }
      \u003CModule\u003E.CSwgRepository\u002ESConfiguation\u002E\u007Bdtor\u007D(&sconfiguation);
      return repositoryTreeFiles;
    }

    public static unsafe PrioritisedFile[] GetRepositoryTreeFiles(string repoScriptFileName)
    {
      basic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E stdAllocatorWcharT1;
      \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cwchar_t\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorWcharT1, &repoScriptFileName);
      PrioritisedFile[] repositoryTreeFiles;
      // ISSUE: fault handler
      try
      {
        basic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E stdAllocatorWcharT2;
        basic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E* stdAllocatorWcharTPtr1 = &stdAllocatorWcharT2;
        basic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E* stdAllocatorWcharTPtr2 = \u003CModule\u003E.std\u002Ebasic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u002E\u007Bctor\u007D(&stdAllocatorWcharT2, &stdAllocatorWcharT1);
        CSwgRepository.SConfiguation sconfiguation;
        \u003CModule\u003E.CSwgRepository\u002ESConfiguation\u002E\u007Bctor\u007D(&sconfiguation, stdAllocatorWcharTPtr2);
        // ISSUE: fault handler
        try
        {
          repositoryTreeFiles = new PrioritisedFile[(int) \u003CModule\u003E.std\u002Evector\u003CSPrioritisedFile\u002Cstd\u003A\u003Aallocator\u003CSPrioritisedFile\u003E\u0020\u003E\u002Esize(\u003CModule\u003E.CSwgRepository\u002ESConfiguation\u002EGetFiles(&sconfiguation))];
          int index = 0;
          vector\u003CSPrioritisedFile\u002Cstd\u003A\u003Aallocator\u003CSPrioritisedFile\u003E\u0020\u003E* files = \u003CModule\u003E.CSwgRepository\u002ESConfiguation\u002EGetFiles(&sconfiguation);
          _Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CSPrioritisedFile\u003E\u0020\u003E\u0020\u003E sprioritisedFile1;
          \u003CModule\u003E.std\u002Evector\u003CSPrioritisedFile\u002Cstd\u003A\u003Aallocator\u003CSPrioritisedFile\u003E\u0020\u003E\u002Ebegin(files, &sprioritisedFile1);
          _Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CSPrioritisedFile\u003E\u0020\u003E\u0020\u003E sprioritisedFile2;
          \u003CModule\u003E.std\u002Evector\u003CSPrioritisedFile\u002Cstd\u003A\u003Aallocator\u003CSPrioritisedFile\u003E\u0020\u003E\u002Eend(files, &sprioritisedFile2);
          if (\u003CModule\u003E.std\u002E_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CSPrioritisedFile\u003E\u0020\u003E\u0020\u003E\u002E\u0021\u003D(&sprioritisedFile1, &sprioritisedFile2))
          {
            do
            {
              SPrioritisedFile* native = \u003CModule\u003E.std\u002E_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CSPrioritisedFile\u003E\u0020\u003E\u0020\u003E\u002E\u002A(&sprioritisedFile1);
              repositoryTreeFiles[index] = new PrioritisedFile(native);
              ++index;
              \u003CModule\u003E.std\u002E_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CSPrioritisedFile\u003E\u0020\u003E\u0020\u003E\u002E\u002B\u002B(&sprioritisedFile1);
            }
            while (\u003CModule\u003E.std\u002E_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CSPrioritisedFile\u003E\u0020\u003E\u0020\u003E\u002E\u0021\u003D(&sprioritisedFile1, &sprioritisedFile2));
          }
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(CSwgRepository\u002ESConfiguation\u002E\u007Bdtor\u007D), (void*) &sconfiguation);
        }
        \u003CModule\u003E.CSwgRepository\u002ESConfiguation\u002E\u007Bdtor\u007D(&sconfiguation);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorWcharT1);
      }
      \u003CModule\u003E.std\u002Ebasic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorWcharT1);
      return repositoryTreeFiles;
    }
  }
}
