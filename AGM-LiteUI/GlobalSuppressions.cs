//-----------------------------------------------------------------------
// <copyright file="GlobalSuppressions.cs" company="Aquila Enterprises">
// Copyright (c) Kevin Seiden. The MIT License.
// </copyright>
//-----------------------------------------------------------------------

// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the
// Code Analysis results, point to "Suppress Message", and click
// "In Suppression File".
// You do not need to add suppressions to this file manually.
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames", Justification = "KSP dependencies are not signed.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "ActionGroupManager.Program.AddDebugLog(System.String)", Scope = "member", Target = "ActionGroupManager.LiteUi.TweakableUi.#Start()", Justification = "Debug log does not need to be localized.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "ActionGroupManager.Program.AddDebugLog(System.String)", Scope = "member", Target = "ActionGroupManager.LiteUi.TweakableUi.#SetupRootModule()", Justification = "Debug log does not need to be localized.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "ActionGroupManager.Program.AddDebugLog(System.String)", Scope = "member", Target = "ActionGroupManager.LiteUi.TweakableUi.#OnPartDie(Part)", Justification = "Debug log does not need to be localized.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "ActionGroupManager.Program.AddDebugLog(System.String)", Scope = "member", Target = "ActionGroupManager.LiteUi.TweakableUi.#OnPartActionUICreate(Part)", Justification = "Debug log does not need to be localized.")]