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
        public int ran;
        private readonly FlashbangGun _plugin;

        public EventHandlers(FlashbangGun plugin) => _plugin = plugin;

        public void OnShooting(ShootingEventArgs ev)
        {
            if (ev.Player.CurrentItem?.Type == ItemType.GunCom45)
            {
                ev.IsAllowed = false;

                {
                    d++;
                    Random rand = new Random();
                    int ran = rand.Next(1,200);
                    Throwable throwable = (Throwable)Item.Create(ItemType.SCP018);
                    ev.Player.ThrowItem(throwable, true);
                    if (randomint <= 5){
                        ev.Player.Health += 500;
                    }
                    else {ev.Player.Health - randomint}
                    if (d >= 10)
                    { ev.Player.Explode();
                        d = 0;
                    }
                }

                if (_plugin.Config.Debug)
                {
                    Log.Info($"{ev.Player.Nickname} this guy fired the flashbang gun.");
                }
            }
        }
    }
}
