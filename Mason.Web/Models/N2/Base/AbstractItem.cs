using System.Collections.Generic;
using N2;
using N2.Collections;

namespace Mason.Web.Models.N2.Base {
	public abstract class AbstractItem : ContentItem {
		public virtual IList<T> GetChildren<T>() where T : ContentItem {
			return new ItemList<T>(Children, new AccessFilter(), new TypeFilter(typeof(T)));
		}

		public virtual IList<T> GetChildren<T>(string zoneName) where T : ContentItem {
			return new ItemList<T>(Children, new AccessFilter(), new TypeFilter(typeof(T)), new ZoneFilter(zoneName));
		}
	}
}