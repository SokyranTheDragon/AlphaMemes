﻿using System;
using RimWorld;
using Verse;
using System.Collections.Generic;

namespace AlphaMemes
{
	[DefOf]
	public static class InternalDefOf
	{
		static InternalDefOf()
		{
			DefOfHelper.EnsureInitializedInCtor(typeof(InternalDefOf));
		}

		public static PreceptDef AM_Violence_Abhorrent_Strict;

		public static PreceptDef AM_ArtProductionSpeed_Increased;
		public static PreceptDef AM_Art_Desired;
		public static PreceptDef AM_ArtQuality_Expected;

		public static PreceptDef AM_AnimalDespised;

		public static PreceptDef AM_Bonding_Abhorrent;

		public static PreceptDef AM_Dryads_Enhanced;

		public static PreceptDef AM_Armour_Blunt;
		public static PreceptDef AM_Armour_Sharp;
		public static PreceptDef AM_Armour_Heat;

		public static PreceptDef AM_Mood_Volatile;
		public static PreceptDef AM_CombatProwess_Increased;
		public static PreceptDef AM_CombatProwess_Melee;

		public static PreceptDef AM_Reliquaries_Forbidden;



		public static HistoryEventDef AM_SomeoneDied;
		public static HistoryEventDef AM_HarvestedNonColonistOrgan;
		public static HistoryEventDef AM_DespisedAnimalDied;
		public static HistoryEventDef AM_AnimalDied;
		public static HistoryEventDef AM_TameAnimal;
		public static HistoryEventDef AM_TrainAnimal;
		public static HistoryEventDef AM_AnimalReleased;
		public static HistoryEventDef AM_UsedMelee;
		public static HistoryEventDef AM_UsedRanged;
		public static HistoryEventDef AM_BuildingReliquary;

		public static ThingDef AM_TrapBlunt;

		public static ThingDef AM_AnimalDatabase;

		public static ThingDef AM_BlocksPristineLimestone;

		public static MemeDef AM_Madness;

		public static MemeDef AM_BiologicalDefilers;

		public static HediffDef AM_CatharsisHediff;
		public static HediffDef AM_UtilityDryadHediff;
		public static HediffDef AM_CombatDryadHediff;
		public static HediffDef AM_GenericDryadHediff;

		public static SoundDef AM_RitualSustainer_MaddeningChant;



		public static PawnKindDef Dryad_Woodmaker;
		public static PawnKindDef Dryad_Berrymaker;
		public static PawnKindDef Dryad_Medicinemaker;
		public static PawnKindDef Dryad_Carrier;		
		public static PawnKindDef Dryad_Clawer;
		public static PawnKindDef Dryad_Barkskin;
		public static PawnKindDef AM_UnshackledDryad;

		[MayRequireRoyalty]
		public static ThoughtDef AM_DeathKnellThought;

		[MayRequireRoyalty]
		public static PreceptDef AM_Abilities_DeathKnell;
	}
}
