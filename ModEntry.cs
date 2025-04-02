using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;
using StardewValley.Tools;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.Objects;
using System;

using FlyingWeaponMount;
using SpinningWeaponAndToolMod;
using HarmonyLib;
using GenericModConfigMenu;
using System.Globalization;


namespace FlyingWeaponMount
{
    public class ModConfig
    {
        public SButton WeaponFlyModeOnOffToggleHotkey = SButton.LeftShift;
        public SButton LoadOptionsToPickModdedWeaponImage = SButton.F7;
        public float MovementSpeedMultiplier { get; set; } = 1.0f;
        public float StaminaDrainPerTenthSecond { get; set; } = 0.2f;
        public float HoverHeightOffGround { get; set; } = -50.0f;
        public float FarmerHoverAboveWeapon { get; set; } = 40.0f;
        public Color weaponColorUp { get; set; } = new Color(255, 255, 255, 80);
        public Color weaponColorDown { get; set; } = new Color(255, 255, 255, 100);
        public Color weaponColorRight { get; set; } = new Color(255, 255, 255, 160);
        public Color weaponColorLeft { get; set; } = new Color(255, 255, 255, 160);
        

        public List<WeaponSpriteData> weaponSpriteData { get; set; } = new List<WeaponSpriteData>
        {
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Rusty Sword", itemCategoryAndItemID = "(W)0", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(0,0,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Silver Saber", itemCategoryAndItemID = "(W)1", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(16,0,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Dark Sword", itemCategoryAndItemID = "(W)2", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(32,0,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Holy Blade", itemCategoryAndItemID = "(W)3", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(48,0,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Galaxy Sword", itemCategoryAndItemID = "(W)4", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(64,0,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Bone Sword", itemCategoryAndItemID = "(W)5", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(80,0,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Iron Edge", itemCategoryAndItemID = "(W)6", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(96,0,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Templar's Blade", itemCategoryAndItemID = "(W)7", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(112,0,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Obsidian Edge", itemCategoryAndItemID = "(W)8", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(0,16,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Lava Katana", itemCategoryAndItemID = "(W)9", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(16,16,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Claymore", itemCategoryAndItemID = "(W)10", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(32,16,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Steel Smallsword", itemCategoryAndItemID = "(W)11", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(48,16,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Wooden Blade", itemCategoryAndItemID = "(W)12", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(64,16,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Insect Head", itemCategoryAndItemID = "(W)13", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(80,16,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Neptune's Glaive", itemCategoryAndItemID = "(W)14", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(96,16,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Forest Sword", itemCategoryAndItemID = "(W)15", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(112,16,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Carving Knife", itemCategoryAndItemID = "(W)16", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(0,32,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Iron Dirk", itemCategoryAndItemID = "(W)17", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(16,32,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Burglar's Shank", itemCategoryAndItemID = "(W)18", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(32,32,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Shadow Dagger", itemCategoryAndItemID = "(W)19", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(48,32,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Elf Blade", itemCategoryAndItemID = "(W)20", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(64,32,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Crystal Dagger", itemCategoryAndItemID = "(W)21", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(80,32,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Wind Spire", itemCategoryAndItemID = "(W)22", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(96,32,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Galaxy Dagger", itemCategoryAndItemID = "(W)23", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(112,32,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Wood Club", itemCategoryAndItemID = "(W)24", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(0,48,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Alex's Bat", itemCategoryAndItemID = "(W)25", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(16,48,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Lead Rod", itemCategoryAndItemID = "(W)26", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(32,48,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Wood Mallet", itemCategoryAndItemID = "(W)27", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(48,48,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "The Slammer", itemCategoryAndItemID = "(W)28", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(64,48,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Galaxy Hammer", itemCategoryAndItemID = "(W)29", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(80,48,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Sam's Old Guitar", itemCategoryAndItemID = "(W)30", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(96,48,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Femur", itemCategoryAndItemID = "(W)31", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(112,48,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Slingshot", itemCategoryAndItemID = "(W)32", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(0,64,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Master Slingshot", itemCategoryAndItemID = "(W)33", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(16,64,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Galaxy Slingshot", itemCategoryAndItemID = "(W)34", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(32,64,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Elliott's Pencil", itemCategoryAndItemID = "(W)35", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(48,64,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Maru's Wrench", itemCategoryAndItemID = "(W)36", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(64,64,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Harvey's Mallet", itemCategoryAndItemID = "(W)37", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(80,64,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Penny's Fryer", itemCategoryAndItemID = "(W)38", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(96,64,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Leah's Whittler", itemCategoryAndItemID = "(W)39", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(112,64,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Abby's Planchette", itemCategoryAndItemID = "(W)40", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(0,80,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Seb's Lost Mace", itemCategoryAndItemID = "(W)41", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(16,80,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Haley's Iron", itemCategoryAndItemID = "(W)42", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(32,80,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Pirate's Sword", itemCategoryAndItemID = "(W)43", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(48,80,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Cutlass", itemCategoryAndItemID = "(W)44", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(64,80,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Wicked Kris", itemCategoryAndItemID = "(W)45", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(80,80,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Kudgel", itemCategoryAndItemID = "(W)46", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(96,80,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Scythe", itemCategoryAndItemID = "(W)47", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(112,80,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Yeti Tooth", itemCategoryAndItemID = "(W)48", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(0,96,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Rapier", itemCategoryAndItemID = "(W)49", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(16,96,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Steel Falchion", itemCategoryAndItemID = "(W)50", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(32,96,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Broken Trident", itemCategoryAndItemID = "(W)51", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(48,96,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Tempered Broadsword", itemCategoryAndItemID = "(W)52", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(64,96,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Golden Scythe", itemCategoryAndItemID = "(W)53", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(80,96,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Dwarf Sword", itemCategoryAndItemID = "(W)54", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(96,96,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Dwarf Hammer", itemCategoryAndItemID = "(W)55", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(112,96,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Dwarf Dagger", itemCategoryAndItemID = "(W)56", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(0,112,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Dragontooth Cutlass", itemCategoryAndItemID = "(W)57", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(16,112,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Dragontooth Club", itemCategoryAndItemID = "(W)58", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(32,112,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Dragontooth Shiv", itemCategoryAndItemID = "(W)59", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(48,112,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Ossified Blade", itemCategoryAndItemID = "(W)60", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(64,112,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Iridium Needle", itemCategoryAndItemID = "(W)61", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(80,112,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Infinity Blade", itemCategoryAndItemID = "(W)62", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(96,112,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Infinity Gavel", itemCategoryAndItemID = "(W)63", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(112,112,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Infinity Dagger", itemCategoryAndItemID = "(W)64", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(0,128,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Meowmere", itemCategoryAndItemID = "(W)65", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(16,128,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Iridium Scythe", itemCategoryAndItemID = "(W)66", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(32,128,16,16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Axe", itemCategoryAndItemID = "(T)Axe", tilesheetName = "TileSheets\\tools", SourceRect = new Rectangle(80,160,16,32)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Copper Axe", itemCategoryAndItemID = "(T)CopperAxe", tilesheetName = "TileSheets\\tools", SourceRect = new Rectangle(192,160,16,32)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Steel Axe", itemCategoryAndItemID = "(T)SteelAxe", tilesheetName = "TileSheets\\tools", SourceRect = new Rectangle(304,160,16,32)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Gold Axe", itemCategoryAndItemID = "(T)GoldAxe", tilesheetName = "TileSheets\\tools", SourceRect = new Rectangle(80,192,16,32)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Iridium Axe", itemCategoryAndItemID = "(T)IridiumAxe", tilesheetName = "TileSheets\\tools", SourceRect = new Rectangle(192,192,16,32)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Pickaxe", itemCategoryAndItemID = "(T)Pickaxe", tilesheetName = "TileSheets\\tools", SourceRect = new Rectangle(80,96,16,32)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Copper Pickaxe", itemCategoryAndItemID = "(T)CopperPickaxe", tilesheetName = "TileSheets\\tools", SourceRect = new Rectangle(192,96,16,32)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Steel Pickaxe", itemCategoryAndItemID = "(T)SteelPickaxe", tilesheetName = "TileSheets\\tools", SourceRect = new Rectangle(304,96,16,32)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Gold Pickaxe", itemCategoryAndItemID = "(T)GoldPickaxe", tilesheetName = "TileSheets\\tools", SourceRect = new Rectangle(80,128,16,32)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Iridium Pickaxe", itemCategoryAndItemID = "(T)IridiumPickaxe", tilesheetName = "TileSheets\\tools", SourceRect = new Rectangle(192,128,16,32)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Rusty Sword", itemCategoryAndItemID = "(W)0", tilesheetName = "TileSheets\\weapons", SourceRect = new Rectangle(0, 0, 16, 16)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Axe", itemCategoryAndItemID = "(T)Axe", tilesheetName = "TileSheets\\tools", SourceRect = new Rectangle(80,160,16,32)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Copper Axe", itemCategoryAndItemID = "(T)CopperAxe", tilesheetName = "TileSheets\\tools", SourceRect = new Rectangle(192,160,16,32)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Steel Axe", itemCategoryAndItemID = "(T)SteelAxe", tilesheetName = "TileSheets\\tools", SourceRect = new Rectangle(304,160,16,32)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Gold Axe", itemCategoryAndItemID = "(T)GoldAxe", tilesheetName = "TileSheets\\tools", SourceRect = new Rectangle(80,192,16,32)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Iridium Axe", itemCategoryAndItemID = "(T)IridiumAxe", tilesheetName = "TileSheets\\tools", SourceRect = new Rectangle(192,192,16,32)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Pickaxe", itemCategoryAndItemID = "(T)Pickaxe", tilesheetName = "TileSheets\\tools", SourceRect = new Rectangle(80,96,16,32)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Copper Pickaxe", itemCategoryAndItemID = "(T)CopperPickaxe", tilesheetName = "TileSheets\\tools", SourceRect = new Rectangle(192,96,16,32)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Steel Pickaxe", itemCategoryAndItemID = "(T)SteelPickaxe", tilesheetName = "TileSheets\\tools", SourceRect = new Rectangle(304,96,16,32)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Gold Pickaxe", itemCategoryAndItemID = "(T)GoldPickaxe", tilesheetName = "TileSheets\\tools", SourceRect = new Rectangle(80,128,16,32)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Iridium Pickaxe", itemCategoryAndItemID = "(T)IridiumPickaxe", tilesheetName = "TileSheets\\tools", SourceRect = new Rectangle(192,128,16,32)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Watering Can", itemCategoryAndItemID = "(T)WateringCan", tilesheetName = "TileSheets\\tools", SourceRect = new Rectangle(48,224,16,32)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Copper Watering Can", itemCategoryAndItemID = "(T)CopperWateringCan", tilesheetName = "TileSheets\\tools", SourceRect = new Rectangle(160,224,16,32)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Steel Watering Can", itemCategoryAndItemID = "(T)SteelWateringCan", tilesheetName = "TileSheets\\tools", SourceRect = new Rectangle(272,224,16,32)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Gold Watering Can", itemCategoryAndItemID = "(T)GoldWateringCan", tilesheetName = "TileSheets\\tools", SourceRect = new Rectangle(48,256,16,32)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Iridium Watering Can", itemCategoryAndItemID = "(T)IridiumWateringCan", tilesheetName = "TileSheets\\tools", SourceRect = new Rectangle(160,256,16,32)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Hoe", itemCategoryAndItemID = "(T)Hoe", tilesheetName = "TileSheets\\tools", SourceRect = new Rectangle(80,32,16,32)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Copper Hoe", itemCategoryAndItemID = "(T)CopperHoe", tilesheetName = "TileSheets\\tools", SourceRect = new Rectangle(192,32,16,32)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Steel Hoe", itemCategoryAndItemID = "(T)SteelHoe", tilesheetName = "TileSheets\\tools", SourceRect = new Rectangle(304,32,16,32)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Gold Hoe", itemCategoryAndItemID = "(T)GoldHoe", tilesheetName = "TileSheets\\tools", SourceRect = new Rectangle(80,64,16,32)},
            new WeaponSpriteData{ModID = null, fullPath = null, ItemName= "Iridium Hoe", itemCategoryAndItemID = "(T)IridiumHoe", tilesheetName = "TileSheets\\tools", SourceRect = new Rectangle(192,64,16,32)}

        };

    }

    public class WeaponSpriteData
    {
        public string ModID { get; set; }
        public string fullPath { get; set; }
        public string ItemName { get; set; }
        public string itemCategoryAndItemID { get; set; }
        public string tilesheetName { get; set; }
        public Rectangle SourceRect { get; set; }

    }
}
public class ModEntry : Mod
{
    public static ITranslationHelper i18n;
    public static ModEntry Instance { get; private set; }
    private ModConfig Config;
    private enum MovementMode { Run, FlyingWeapon }
    private MovementMode currentMode = MovementMode.Run;
    private float hoverOffset = 0f;
    private int hoverTick = 0;
    private float FacingDirection = 0f;
    private Vector2 offset = Vector2.Zero;
    private Color weaponColor = new Color(255, 255, 255, 160);
    private bool isWeaponFlying = false;
    private Vector2? initialCameraOffset = null;
    private Vector2? playerCenter = null;

    public override void Entry(IModHelper helper)
    {
        Instance = this;
        Config = helper.ReadConfig<ModConfig>();
        i18n = helper.Translation;

        var harmony = new Harmony(ModManifest.UniqueID);
        harmony.PatchAll();


        helper.Events.Input.ButtonPressed += OnButtonPressed;
        helper.Events.GameLoop.UpdateTicked += OnUpdateTicked;
        helper.Events.Display.RenderedWorld += OnRenderedWorld;
        helper.Events.GameLoop.GameLaunched += GameLoop_GameLaunched;

    }



    private void OnButtonPressed(object sender, ButtonPressedEventArgs e)
    {
        if (!Context.IsPlayerFree || Game1.player == null)
            return;

        if (e.Button == Config.LoadOptionsToPickModdedWeaponImage)
        {
            Game1.activeClickableMenu = new ModImagePreviewer(Instance, Config, i18n);
        }


        if (e.Button == SButton.LeftShift)
        {
            if (IsMovementKeyDown())
                return; 

            // Only toggle between Run and FlyingWeapon
            if (currentMode == MovementMode.Run)
            {
                if (Game1.player.CurrentItem is MeleeWeapon)
                {
                    currentMode = MovementMode.FlyingWeapon;
                    SnapCameraToPlayer(); 
                }

                else
                    Game1.addHUDMessage(new HUDMessage(i18n.Get("HUDMessage-MustUseMeleeWeapon"), HUDMessage.error_type));
            }
            else
            {
                stopSwordFlyingAndReset();
                currentMode = MovementMode.Run;
            }
        }
    }


    private void SnapCameraToPlayer()
    {
        Game1.forceSnapOnNextViewportUpdate = true;

        // Manually snap the camera to the player's standing position
        Point standingPixel = Game1.player.StandingPixel;

        Game1.viewport.X = standingPixel.X - Game1.viewport.Width / 2;
        Game1.viewport.Y = standingPixel.Y - Game1.viewport.Height / 2;

        // Clamp to the map bounds
        Game1.viewport.X = Math.Clamp(Game1.viewport.X, 0, Game1.currentLocation.Map.DisplayWidth - Game1.viewport.Width);
        Game1.viewport.Y = Math.Clamp(Game1.viewport.Y, 0, Game1.currentLocation.Map.DisplayHeight - Game1.viewport.Height);
    }







    private void UpdateFacingFromInput()
    {
        float speed = Game1.player.getMovementSpeed() * Config.MovementSpeedMultiplier;
        float dt = (float)Game1.currentGameTime.ElapsedGameTime.TotalMilliseconds / 16.67f;


        if (Helper.Input.IsDown(SButton.W) || Helper.Input.IsDown(SButton.Up))  // UP
        {
            FacingDirection = -MathF.PI / 4f;
            offset = new Vector2(28, 42);
            weaponColor = Config.weaponColorUp;

            Vector2 move = new Vector2(0f, -(speed * dt));
            Vector2 newPos = Game1.player.position.Get() + move;

            Rectangle hitbox = Game1.player.GetBoundingBox();
            hitbox.Offset(0, (int)move.Y);

            if (!Game1.currentLocation.isCollidingPosition(hitbox, Game1.viewport, true, 0, false, Game1.player))
            {
                isWeaponFlying = true;
    
                Game1.player.position.Set(newPos);
            }
        }
        else if (Helper.Input.IsDown(SButton.D) || Helper.Input.IsDown(SButton.Right))  // RIGHT
        {
            FacingDirection = MathF.PI / 4f;
            offset = new Vector2(-32, 16);
            weaponColor = Config.weaponColorRight;

            Vector2 move = new Vector2(speed * dt, 0f);
            Vector2 newPos = Game1.player.position.Get() + move;

            Rectangle hitbox = Game1.player.GetBoundingBox();
            hitbox.Offset((int)move.X, 0);

            if (!Game1.currentLocation.isCollidingPosition(hitbox, Game1.viewport, true, 0, false, Game1.player))
            {

                isWeaponFlying = true;

                Game1.player.position.Set(newPos);
            }
        }
        else if (Helper.Input.IsDown(SButton.S) || Helper.Input.IsDown(SButton.Down))  // DOWN
        {
            FacingDirection = -5 * MathF.PI / 4f;
            offset = new Vector2(32, -32);   ///32,-32

            weaponColor = Config.weaponColorDown;
            Vector2 move = new Vector2(0f, speed * dt);
            Vector2 newPos = Game1.player.position.Get() + move;

            Rectangle hitbox = Game1.player.GetBoundingBox();
            hitbox.Offset(0, (int)move.Y);

            if (!Game1.currentLocation.isCollidingPosition(hitbox, Game1.viewport, true, 0, false, Game1.player))
            {

                isWeaponFlying = true;

                Game1.player.position.Set(newPos);
            }
        }
        else if (Helper.Input.IsDown(SButton.A) || Helper.Input.IsDown(SButton.Left))  // LEFT
        {
            FacingDirection = -3 * MathF.PI / 4f;
            offset = new Vector2(80, 16);
            weaponColor = Config.weaponColorLeft;

            Vector2 move = new Vector2(-(speed * dt), 0f);
            Vector2 newPos = Game1.player.position.Get() + move;

            Rectangle hitbox = Game1.player.GetBoundingBox();
            hitbox.Offset((int)move.X, 0);

            if (!Game1.currentLocation.isCollidingPosition(hitbox, Game1.viewport, true, 0, false, Game1.player))
            {
                isWeaponFlying = true;

                Game1.player.position.Set(newPos);

            }
        }

    }

    private void stopSwordFlyingAndReset()
    {
        Game1.player.canMove = true;
        Game1.player.yOffset = 0f;
        initialCameraOffset = null;
        currentMode = MovementMode.Run;
   
    }

    private void OnUpdateTicked(object sender, UpdateTickedEventArgs e)
    {
        if (!Context.IsWorldReady)
            return;


        if (currentMode != MovementMode.FlyingWeapon)
        {
            return;
        }
        if (Game1.currentLocation.currentEvent != null || Game1.eventUp || Game1.fadeToBlack)
            return; // Don't update flying or camera right now


        if (Game1.player.CurrentItem is not MeleeWeapon)
        {

            stopSwordFlyingAndReset();
            Game1.addHUDMessage(new HUDMessage(i18n.Get("HUDMessage-MustUseMeleeWeapon"), HUDMessage.error_type));
            return;
        }

        if (Game1.player.isRidingHorse())
        {
            stopSwordFlyingAndReset();
            return;
        }

        UpdateFacingFromInput();
        // Hover effect using sine wave
        Game1.player.Halt();
        hoverTick++;
        hoverOffset = Config.HoverHeightOffGround + (float)Math.Sin(hoverTick / 10f) * 4f; //sets hover height, adjust first number for height
        SnapCameraToPlayer();



        if (e.IsMultipleOf(6))
        {

            if (Game1.player.Stamina <= 0)
            {
                currentMode = MovementMode.Run;
                Game1.addHUDMessage(new HUDMessage(i18n.Get("HUDMessage-TooExhausted"), HUDMessage.error_type));
                return;

            }

            if (isWeaponFlying)
            {
                Game1.player.Stamina = Math.Max(0, Game1.player.Stamina - Config.StaminaDrainPerTenthSecond);
                isWeaponFlying = false;
            }

        }
    }


    private void OnRenderedWorld(object sender, RenderedWorldEventArgs e)
    {
        if (currentMode != MovementMode.FlyingWeapon)
            return;

        if (Game1.player.CurrentItem is not MeleeWeapon weapon)
            return;

        Vector2 playerPos = Game1.player.Position;
        SpriteBatch b = e.SpriteBatch;



        string weaponID = Game1.player.CurrentItem.GetItemTypeId() + Game1.player.CurrentItem.ItemId;
        WeaponSpriteData match = Config.weaponSpriteData
            .FirstOrDefault(w => w.itemCategoryAndItemID == weaponID);

        string tileSheet = "TileSheets\\weapons";
        Rectangle sourceRect = new Rectangle(0, 0, 16, 16);

        string fullPath = null;
        if (match != null)
        {
            tileSheet = match.tilesheetName;
            sourceRect = match.SourceRect;
            fullPath = Path.Combine(ModEntry.Instance.Helper.DirectoryPath, tileSheet.Replace('/', Path.DirectorySeparatorChar));
        }

        //Console.WriteLine("FullPath :" + fullPath);
        Texture2D weaponTex;
        if (File.Exists(fullPath))
        {
            using var stream = new FileStream(fullPath, FileMode.Open, FileAccess.Read);
            weaponTex = Texture2D.FromStream(Game1.graphics.GraphicsDevice, stream);
        }
        else
        {
            weaponTex = Game1.content.Load<Texture2D>(tileSheet);
        }

        sourceRect = match.SourceRect;
        if (FacingDirection == -MathF.PI / 4f) // mean person is facing upward upward then change height of images
        {
            sourceRect = new Rectangle(sourceRect.X, sourceRect.Y, 16, 16);
        }
        else if (FacingDirection == -5 * MathF.PI / 4f) // mean person is facing downwards then change height of images
        {
            sourceRect = new Rectangle(sourceRect.X, sourceRect.Y, 16, 16);
        }


        Vector2 drawPos = Game1.GlobalToLocal(playerPos);

        drawPos += offset;
        drawPos.Y += hoverOffset;

        float swordLayerDepth = (Game1.player.getStandingPosition().Y - 32f) / 10000f;

        float angle = FacingDirection;

        b.Draw(
            weaponTex,
            drawPos,
            sourceRect,
            weaponColor, //white with some transparency
            angle,
            new Vector2(0f, sourceRect.Height),
            6f,
            SpriteEffects.None,
            -10f
        );

        Game1.player.FarmerSprite.StopAnimation();
        Game1.player.yOffset = -hoverOffset + Config.FarmerHoverAboveWeapon;//keep farmer higher than sword update the last number to adjust height
    }


    private bool IsMovementKeyDown()
    {
        return Helper.Input.IsDown(SButton.W) || Helper.Input.IsDown(SButton.A) ||
               Helper.Input.IsDown(SButton.S) || Helper.Input.IsDown(SButton.D) ||
               Helper.Input.IsDown(SButton.Up) || Helper.Input.IsDown(SButton.Down) ||
               Helper.Input.IsDown(SButton.Left) || Helper.Input.IsDown(SButton.Right);
    }



    private void GameLoop_GameLaunched(object? sender, GameLaunchedEventArgs e)
    {

        // Uses Generic Mod Config Menu API to build a config UI.
        var gmcm = ModEntry.Instance.Helper.ModRegistry.GetApi<IGenericModConfigMenuApi>("spacechase0.GenericModConfigMenu");
        if (gmcm == null)
            return;

        // Register the mod.
        gmcm.Register(ModEntry.Instance.ModManifest, () => Config = new ModConfig(), () => ModEntry.Instance.Helper.WriteConfig(Config));


        gmcm.AddKeybind(
            ModManifest,
            name: () => i18n.Get("hotkeys.toggle_mount.name"),
            tooltip: () => i18n.Get("hotkeys.toggle_mount.tooltip"),
            getValue: () => Config.WeaponFlyModeOnOffToggleHotkey,
            setValue: value => Config.WeaponFlyModeOnOffToggleHotkey = value
        );

        gmcm.AddKeybind(
            ModManifest,
            name: () => i18n.Get("hotkeys.image_menu.name"),
            tooltip: () =>  i18n.Get("hotkeys.image_menu.tooltip"),
            getValue: () => Config.LoadOptionsToPickModdedWeaponImage,
            setValue: value => Config.LoadOptionsToPickModdedWeaponImage = value
        );


        gmcm.AddNumberOption(
            mod: ModManifest,
            getValue: () => Config.MovementSpeedMultiplier,
            setValue: value => Config.MovementSpeedMultiplier = value,
            name: () => i18n.Get("movement.speed_multiplier.name"),
            tooltip: () => i18n.Get("movement.speed_multiplier.tooltip"),
            min: 0.0f,
            max: 5.0f,
            interval: 0.01f
        );

        gmcm.AddNumberOption(
            mod: ModManifest,
            getValue: () => Config.StaminaDrainPerTenthSecond,
            setValue: value => Config.StaminaDrainPerTenthSecond = value,
            name: () => i18n.Get("movement.stamina_drain.name"),
            tooltip: () => i18n.Get("movement.stamina_drain.tooltip"),
            min: 0.0f,
            max: 3.0f,
            interval: 0.01f
        );

        gmcm.AddNumberOption(
            mod: ModManifest,
            getValue: () => Config.HoverHeightOffGround,
            setValue: value => Config.HoverHeightOffGround = value,
            name: () => i18n.Get("movement.hover_height.name"),
            tooltip: () => i18n.Get("movement.hover_height.tooltip"),
            min: -200.0f,
            max: 200.0f,
            interval: 1.0f
        );
        gmcm.AddNumberOption(
            mod: ModManifest,
            getValue: () => Config.FarmerHoverAboveWeapon,
            setValue: value => Config.FarmerHoverAboveWeapon = value,
            name: () => i18n.Get("movement.farmer_above_weapon.name"),
            tooltip: () => i18n.Get("movement.farmer_above_weapon.tooltip"),
            min: -200.0f,
            max: 200.0f,
            interval: 1.0f
        );


    }
}

