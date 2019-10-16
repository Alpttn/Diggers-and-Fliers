namespace Diggers_and_Fliers
{
    public interface IFlying
    {
        int MaxFlyingSpeed { get; set; }
    
        void Fly();
        
    }
}