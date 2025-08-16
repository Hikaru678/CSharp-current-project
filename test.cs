namespace Test;

using System.Runtime.CompilerServices;

struct INFO{
	public int id;
}

class Instance{
	public static INFO[] info=Init(new INFO[3]);

	static INFO[] Init(INFO[] info){
		(info[0],info[1],info[2])=(new(),new(),new());
		return info;
	}
}
