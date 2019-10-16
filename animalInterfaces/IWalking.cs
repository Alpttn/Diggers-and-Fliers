namespace Diggers_and_Fliers
{
    public interface IWalking
    {
        int MaxWalkingSpeed { get; set; }
    
        void Move();
        
    }
}