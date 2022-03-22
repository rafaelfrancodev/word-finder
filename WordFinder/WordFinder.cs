using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordFinder
{
    public class WordFinder
	{
		private readonly HashSet<string> _matrix;

		public WordFinder(IEnumerable<string> matrix)
		{
			_matrix = new HashSet<string>(matrix);
		}

		public IEnumerable<string> Find(IEnumerable<string> wordStream)
		{
			var characterMatrix = wordStream.Select(x => x.ToCharArray()).ToArray();

			var leftToRightSearchString = string.Join(string.Empty, wordStream);
			
			var topToDownSearchStringBuilder = new StringBuilder();
			for (var i = 0; i < characterMatrix.Length; i++)
			{
				for (var j = 0; j < characterMatrix[i].Length; j++)
				{
					topToDownSearchStringBuilder.Append(characterMatrix[j][i]);
				}
			}
			var topToDownSearchString = topToDownSearchStringBuilder.ToString();

			var result = new HashSet<string>();

			result.UnionWith(_matrix.Where(x => leftToRightSearchString.Contains(x)));
			result.UnionWith(_matrix.Where(x => topToDownSearchString.Contains(x)));

			return result.ToList();
		}
	}
}
