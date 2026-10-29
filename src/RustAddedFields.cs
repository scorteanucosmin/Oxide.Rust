using Oxide.Core;
using Oxide.Core.Libraries.Covalence;

namespace Oxide
{
    public static class RustAddedFields
    {
        extension(BasePlayer player)
        {
            public IPlayer IPlayer
            {
                get => AddedFields.Get<IPlayer>(player, "BasePlayer::IPlayer");
                set => AddedFields.Set(player, value, "BasePlayer::IPlayer");
            }
        }

        extension(AutoTurret turret)
        {
            public int consumptionAmount
            {
                get => AddedFields.Get<int>(turret, "AutoTurret::consumptionAmount");
                set => AddedFields.Set(turret, value, "AutoTurret::consumptionAmount");
            }
        }

        extension(SprayCanSpray spray)
        {
            public int splashThreshold
            {
                get => AddedFields.Get<int>(spray, "SprayCanSpray::splashThreshold");
                set => AddedFields.Set(spray, value, "SprayCanSpray::splashThreshold");
            }
        }

        extension(TimeWarning warning)
        {
            public object Placeholder
            {
                get => AddedFields.Get<object>(warning, "TimeWarning::Placeholder");
                set => AddedFields.Set(warning, value, "TimeWarning::Placeholder");
            }
        }
    }
}
