namespace Ziggeo
{
    public delegate void LightLevelDelegate(float level);
    
    public interface ISensorManagerEventsListener
    {
        event LightLevelDelegate LightLevel;
        void InvokeLightLevel(float level);
    }
}