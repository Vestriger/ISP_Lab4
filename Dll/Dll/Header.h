// MathLibrary.h - Contains declarations of math functions
#pragma once

#ifdef MATHLIBRARY_EXPORTS
#define MATHLIBRARY_API __declspec(dllexport)
#else
#define MATHLIBRARY_API __declspec(dllimport)
#endif

extern "C" MATHLIBRARY_API int Add(int a, int b);

extern "C" MATHLIBRARY_API int Subtract(int a, int b);

extern "C" MATHLIBRARY_API int Multiply(int a, int b);

extern "C" MATHLIBRARY_API int Division(int a, int b);

extern "C" MATHLIBRARY_API int RemainderOfTheDivision(int a, int b);
