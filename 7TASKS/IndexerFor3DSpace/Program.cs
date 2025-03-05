/*

Multi-Parameter Indexer for 3D Space
Task: Create a Grid3D class that:
1. Stores values in a 3D space (x, y, z coordinates).
2. Uses an indexer with three integer parameters.
3. Throws an error if any index is out of bounds.

*/

using System;

class Grid3D {
    int[,,] _grid;
    int _gridXSize;
    int _gridYSize;
    int _gridZSize;

    public Grid3D(int x, int y, int z) {
        if (x <= 0 || y <= 0 || z <= 0) {
            throw new ArgumentException("invalid arguments");
        }
        _gridXSize = x;
        _gridYSize = y;
        _gridZSize = z;
        _grid = new int[_gridXSize, _gridYSize, _gridZSize];
    }

    public int this[int x, int y, int z] {
        get {
            if (OutOfBounds(x, y, z)) {
                throw new IndexOutOfRangeException("Indexes are out of bounds");
            }
            return _grid[x, y, z];
        } 

        set {
            if (OutOfBounds(x, y, z)) {
                throw new IndexOutOfRangeException("Indexes are out of bounds");
            }
            _grid[x, y, z] = value;
        }
    }

    private bool OutOfBounds(int x, int y, int z) {
        return (x < 0 || x >= _gridXSize || y < 0 || y >= _gridYSize || z < 0 || z >= _gridZSize);
    }

    

}

class Program {
    static void Main(string[] Args) {
        Grid3D grid1 = new Grid3D(3,4,5);
        grid1[1, 1, 1] = 111;
        Console.WriteLine($"the value in [1, 1, 1]index is: {grid1[1, 1, 1]}");
    }
}