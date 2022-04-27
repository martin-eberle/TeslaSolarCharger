﻿namespace SmartTeslaAmpSetter.Server.Contracts;

public interface IConfigurationService
{
    string ConfigFileLocation();
    TimeSpan UpdateIntervall();
    string MqqtClientId();
    string MosquitoServer();
    string CurrentPowerToGridUrl();
    string? CurrentInverterPowerUrl();
    string? CurrentPowerToGridJsonPattern();
    bool CurrentPowerToGridInvertValue();
    string TeslaMateApiBaseUrl();
    List<int> CarPriorities();
    string GeoFence();
    TimeSpan TimeUntilSwitchOn();
    TimeSpan MinutesUntilSwitchOff();
    int PowerBuffer();
}