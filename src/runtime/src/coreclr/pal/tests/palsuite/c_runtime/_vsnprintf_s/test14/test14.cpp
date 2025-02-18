// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

/*=====================================================================
**
** Source:    test14.c
**
** Purpose:   Test #14 for the _vsnprintf function.
**
**
**===================================================================*/

#include <palsuite.h>
#include "../_vsnprintf_s.h"

/*
 * Notes: memcmp is used, as is strlen.
 */


PALTEST(c_runtime__vsnprintf_s_test14_paltest_vsnprintf_test14, "c_runtime/_vsnprintf_s/test14/paltest_vsnprintf_test14")
{
    double val = 256.0;
    double neg = -256.0;

    if (PAL_Initialize(argc, argv) != 0)
    {
        return(FAIL);
    }

    DoDoubleTest("foo %e", val,  "foo 2.560000e+002", "foo 2.560000e+02");
    DoDoubleTest("foo %le", val,  "foo 2.560000e+002", "foo 2.560000e+02");
    DoDoubleTest("foo %he", val,  "foo 2.560000e+002", "foo 2.560000e+02");
    DoDoubleTest("foo %14e", val,  "foo  2.560000e+002", "foo   2.560000e+02");
    DoDoubleTest("foo %-14e", val,  "foo 2.560000e+002 ", "foo 2.560000e+02  ");
    DoDoubleTest("foo %.1e", val,  "foo 2.6e+002", "foo 2.6e+02");
    DoDoubleTest("foo %.8e", val,  "foo 2.56000000e+002", "foo 2.56000000e+02");
    DoDoubleTest("foo %014e", val,  "foo 02.560000e+002", "foo 002.560000e+02");
    DoDoubleTest("foo %#e", val,  "foo 2.560000e+002", "foo 2.560000e+02");
    DoDoubleTest("foo %+e", val,  "foo +2.560000e+002", "foo +2.560000e+02");
    DoDoubleTest("foo % e", val,  "foo  2.560000e+002", "foo  2.560000e+02");
    DoDoubleTest("foo %+e", neg,  "foo -2.560000e+002", "foo -2.560000e+02");
    DoDoubleTest("foo % e", neg,  "foo -2.560000e+002", "foo -2.560000e+02");

    PAL_Terminate();
    return PASS;
}
