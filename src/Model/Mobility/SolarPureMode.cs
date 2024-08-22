namespace KostalKsemApiClient.Model.Mobility;

public class SolarPureMode : ChargeModeBase
{
    public SolarPureMode()
    {
        Mode = "pv";
        MinChargingPowerQuota = null;
        MinChargingPowerQuota = 100;
    }
}