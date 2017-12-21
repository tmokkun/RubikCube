using UnityEngine;
using System.Collections;
using Leap;

namespace WidgetShowcase
{
/// <summary>
/// A wrapper for Vector3 that 
/// </summary>
		public struct PointData
		{
				public Vector3 Point;
				public bool HasData;

				public PointData (Vector3 value)
				{
						Point = value;
						HasData = true;
				}

				public PointData (bool placeholder)
				{
						Point = Vector3.zero;
						HasData = false;
				}

		#region equals
				public override bool Equals (object obj)
				{
						if (obj is PointData) {
								return Equals ((PointData)obj);
						}
						return false;
				}

				public override int GetHashCode ()
				{
						if (!HasData) {
							return 0;
						}
						return Point.GetHashCode ();
				}

				public bool Equals (PointData p)
				{
						if (!p.HasData && !HasData)
								return true;
						if (p.HasData != HasData)
								return false;
						return p.Point == Point;
				}

				public static bool operator == (PointData c1, PointData c2)
				{
						return c1.Equals (c2);
				}
		
				public static bool operator != (PointData c1, PointData c2)
				{
						return !c1.Equals (c2);
				}
		#endregion

				public override string ToString ()
				{

						return string.Format ("<< Point data {0} >>", HasData ? Point.ToString () : "--");
				}
		}

}