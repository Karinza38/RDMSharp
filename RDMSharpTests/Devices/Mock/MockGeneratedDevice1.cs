﻿using RDMSharp.ParameterWrapper;

namespace RDMSharpTests.Devices.Mock
{
    internal sealed class MockGeneratedDevice1 : AbstractMockGeneratedDevice
    {
        public override EManufacturer ManufacturerID => (EManufacturer)0x9fff;
        public override ushort DeviceModelID => 20;
        public override ERDM_ProductCategoryCoarse ProductCategoryCoarse => ERDM_ProductCategoryCoarse.CONTROL;
        public override ERDM_ProductCategoryFine ProductCategoryFine => ERDM_ProductCategoryFine.DATA_CONVERSION;
        public override uint SoftwareVersionID => 0x1234;
        public override string DeviceModelDescription => "Test Model Description";
        public override bool SupportDMXAddress => true;

        private static GeneratedPersonality[] PERSONALITYS = [
            new GeneratedPersonality(1, "5CH RGB",
                new Slot(0, ERDM_SlotCategory.INTENSITY, "Dimmer" ),
                new Slot(1, ERDM_SlotCategory.STROBE, "Strobe" , 33),
                new Slot(2, ERDM_SlotCategory.COLOR_ADD_RED, "Red" ),
                new Slot(3, ERDM_SlotCategory.COLOR_ADD_GREEN, "Green" ),
                new Slot(4, ERDM_SlotCategory.COLOR_ADD_BLUE, "Blue" )),
            new GeneratedPersonality(2, "8CH RGBAWY",
                new Slot(0, ERDM_SlotCategory.INTENSITY, "Dimmer" ),
                new Slot(1, ERDM_SlotCategory.STROBE, "Strobe" , 33),
                new Slot(2, ERDM_SlotCategory.COLOR_ADD_RED, "Red" ),
                new Slot(3, ERDM_SlotCategory.COLOR_ADD_GREEN, "Green" ),
                new Slot(4, ERDM_SlotCategory.COLOR_ADD_BLUE, "Blue" ),
                new Slot(5, ERDM_SlotCategory.COLOR_CORRECTION, "Amber" ),
                new Slot(6, ERDM_SlotCategory.COLOR_CORRECTION, "White" ),
                new Slot(7, ERDM_SlotCategory.COLOR_CORRECTION, "Yellow" )),
            new GeneratedPersonality(3, "9CH RGB 16-Bit",
                new Slot(0, ERDM_SlotCategory.INTENSITY, "Dimmer" ),
                new Slot(1, ERDM_SlotCategory.INTENSITY,ERDM_SlotType.SEC_FINE, "Dimmer Fine"),
                new Slot(2, ERDM_SlotCategory.STROBE, "Strobe" , 33),
                new Slot(3, ERDM_SlotCategory.COLOR_ADD_RED, "Red" ),
                new Slot(4, ERDM_SlotCategory.COLOR_ADD_RED, ERDM_SlotType.SEC_FINE,"Red Fine"),
                new Slot(5, ERDM_SlotCategory.COLOR_ADD_GREEN, "Green" ),
                new Slot(6, ERDM_SlotCategory.COLOR_ADD_GREEN, ERDM_SlotType.SEC_FINE,"Green Fine"),
                new Slot(7, ERDM_SlotCategory.COLOR_ADD_BLUE, "Blue" ),
                new Slot(8, ERDM_SlotCategory.COLOR_ADD_BLUE,ERDM_SlotType.SEC_FINE, "Blue Fine" ))];
        public override GeneratedPersonality[] Personalities => PERSONALITYS;
        public MockGeneratedDevice1(RDMUID uid) : base(uid, [ERDM_Parameter.IDENTIFY_DEVICE, ERDM_Parameter.BOOT_SOFTWARE_VERSION_LABEL], "Dummy Manufacturer 9FFF")
        {
            this.DeviceLabel = "Dummy Device 1";
            this.TrySetParameter(ERDM_Parameter.IDENTIFY_DEVICE, false);
            this.TrySetParameter(ERDM_Parameter.BOOT_SOFTWARE_VERSION_LABEL, $"Dummy Software");
        }
    }
}
