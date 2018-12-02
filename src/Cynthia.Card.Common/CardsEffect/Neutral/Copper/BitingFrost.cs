using System.Linq;
using System.Threading.Tasks;
using Alsein.Utilities;

namespace Cynthia.Card
{
	[CardEffectId("14005")]//刺骨冰霜
	public class BitingFrost : CardEffect
	{//在对方单排降下灾厄。回合开始时，对所在排最弱的单位造成2点伤害。
		public BitingFrost(IGwentServerGame game, GameCard card) : base(game, card){}
		public override async Task<int> CardUseEffect()
		{
			return 0;
		}
	}
}