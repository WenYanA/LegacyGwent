using System.Linq;
using System.Threading.Tasks;
using Alsein.Utilities;

namespace Cynthia.Card
{
	[CardEffectId("64011")]//德拉蒙家族好战分子
	public class DrummondWarmonger : CardEffect
	{//从牌组丢弃1张铜色牌。
		public DrummondWarmonger(IGwentServerGame game, GameCard card) : base(game, card){}
		public override async Task<int> CardPlayEffect(bool isSpying)
		{
			return 0;
		}
	}
}