using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Items;
using Exiled.Events.EventArgs;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;
using UnityEngine;
using Exiled.API.Features.Pickups.Projectiles;
namespace FlashbangGun
{
            public Throwable ThrowGrenade(ProjectileType type, bool fullForce = true)
        {
            Throwable throwable = type switch
            {
                ProjectileType.Flashbang => new FlashGrenade(),
                ProjectileType.Scp2176 => new Scp2176(),
                _ => new ExplosiveGrenade(type.GetItemType()),
            };

            ThrowItem(throwable, fullForce);
            return throwable;
        }
    public class EventHandlers
    {
        private readonly FlashbangGun _plugin;

        public EventHandlers(FlashbangGun plugin) => _plugin = plugin;

        public void OnShooting(ShootingEventArgs ev)
        {
            // you can change weapon type from there
            if (ev.Player.CurrentItem?.Type == ItemType.GunCom45)
            {
                ev.IsAllowed = false;

                // you can change to frag grenade if you want
                
                for(int d =1; i < 10; d++) {
                    throwable throwable = (throwable)Item.Create(ItemType.SCP018);
                    ev.Player.ThrowItem(throwable, true); } 
                // you foon linging

                if (_plugin.Config.Debug)
                {
                    Log.Info($"{ev.Player.Nickname} this guy fired the flashbang gun.");
                }
            }
        }
    }
}
