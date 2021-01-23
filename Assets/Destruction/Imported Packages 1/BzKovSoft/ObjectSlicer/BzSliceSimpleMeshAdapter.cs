using System;
using UnityEngine;

namespace BzKovSoft.ObjectSlicer
{
	public class BzSliceSimpleMeshAdapter : IBzSliceAdapter
	{
		Vector3[] _vertices;

		public BzSliceSimpleMeshAdapter()
		{

		}

		public BzSliceSimpleMeshAdapter(Vector3[] vertices)
		{
			_vertices = vertices;
		}

		public Vector3 GetWorldPos(int index)
		{
			Vector3 position = _vertices[index];
			return position;
		}

		public Vector3 GetWorldPos(BzMeshData meshData, int index)
		{
			return meshData.Vertices[index];
		}

		public bool Check(BzMeshData meshData)
		{
			return true;
		}

		public void RebuildMesh(Mesh mesh, Material[] materials, Renderer meshRenderer)
		{
			throw new NotSupportedException();
		}

		public Vector3 GetObjectCenterInWorldSpace()
		{
			return Vector3.zero;
		}
	}
}