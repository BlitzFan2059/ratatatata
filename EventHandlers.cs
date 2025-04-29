using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Items;

using Exiled.Events.EventArgs;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;
using UnityEngine;

namespace FlashbangGun
{
    public class EventHandlers
    {
        
        public int d = 1;
        
       
        private readonly FlashbangGun _plugin;

        public EventHandlers(FlashbangGun plugin) => _plugin = plugin;

        public void OnShooting(ShootingEventArgs ev)
        {
            if (ev.Player.CurrentItem?.Type == ItemType.GunCom45)
            {    
                
                ev.IsAllowed = false;

                
                    d++;
                    
                    
                    Throwable throwable = (Throwable)Item.Create(ItemType.SCP018);
                    
                    ev.Player.ThrowItem(throwable, true);
                    
                    ev.Player.Health -= 30
                    if (d >= 10)
                    { 
                        Throwable throwable32 = (Throwable)Item.Create(ItemType.GrenadeHE);
                        ev.Player.ThrowItem(throwable32);
                        ev.Player.ThrowItem(throwable32);
                        ev.Player.ThrowItem(throwable32);
                        ev.Player.Explode();
                        d = 0;
                    }
                
                    
                if (_plugin.Config.Debug)
                {
                    Log.Info($"{ev.Player.Nickname} this guy fired the flashbang gun.");
                }
            }
            if (ev.Player.CurrentItem?.Type == ItemType.Revolver)
            {    
                
                ev.IsAllowed = false;

                
            
                    
                    
                    Throwable throwable2 = (Throwable)Item.Create(ItemType.SCP500);
                    
                    ev.Player.ThrowItem(throwable2, true);
                    
                    ev.Player.Health -= 10;

        }
    }
}
