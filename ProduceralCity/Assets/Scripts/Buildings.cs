using UnityEngine;
using UnityEditor;
using System.Collections;

public class Buildings : MonoBehaviour
{
    public float MAX_HEIGHT = 200;
    public float MIN_HEIGHT = 25;
    float random;
    GameObject block, tower, borders, squares,triangle, AreaA, 
        AreaB, AreaC, AreaD, AreaE, AreaF, h, outside;

    void areaA()
    {
        squares = createRectangularBuilding(-680,-180,0,0,0, 1);
        squares.transform.parent = AreaA.transform;

        squares = createRectangularBuilding(-510, -180, 0, 0, 0, 1);
        squares.transform.parent = AreaA.transform;

        squares = createRectangularBuilding(-580, -200, 0, 180, 0, 1);
        squares.transform.parent = AreaA.transform;

        squares = createRectangularBuilding(-410, -200, 0, 180, 0, 1);
        squares.transform.parent = AreaA.transform;

        float x = -685;
        float z = -590;
        float oldZ = z;
        for (int i = 3; i >= 0; --i)
        {
           
            for (int j = i; j >= 0; --j)
            {
                tower = createTower(x, z, 0, 0, 0, 1);
                tower.transform.parent = AreaA.transform;                
                z += 80;
            }
            oldZ += 50;
            z = oldZ;
            x += 50;
                
        }
    }

    void areaB()
    {
        squares = createRectangularBuilding(-546, 200, 0, 90, 0, 1);
        squares.transform.parent = AreaB.transform;

        tower = createTower(-558, 104, 0, 0, 0, 1);
        tower.transform.parent = AreaB.transform;

        tower = createTower(-474, 278, 0, 0, 0, 1);
        tower.transform.parent = AreaB.transform;

        tower = createTower(-405, 177, 0, 0, 0, 1);
        tower.transform.parent = AreaB.transform;

        tower = createTower(-345, 83, 0, 0, 0, 1);
        tower.transform.parent = AreaB.transform;
    }

    void areaC()
    {
        h = hospital(315,-420);
        h.transform.parent = AreaC.transform;

        h = hospital(-245, -460);
        h.transform.parent = AreaC.transform;

        float x = 610;
        for (int i = 0; i <= 7; ++i)
        {
            squares = createRectangularBuilding(x, -690, 0, 0, 0, 1);
            squares.transform.parent = AreaC.transform;
            x -= 150;
        }

        h = createCircle(600, -520);
        h.transform.parent = AreaC.transform;

        squares = createRectangularBuilding(40, -180, 0, 0, 0, 1);
        squares.transform.parent = AreaC.transform;

        squares = createRectangularBuilding(140, -205, 0, 180, 0, 1);
        squares.transform.parent = AreaC.transform;

        squares = createRectangularBuilding(40, -380, 0, 0, 0, 1);
        squares.transform.parent = AreaC.transform;

        squares = createRectangularBuilding(140, -405, 0, 180, 0, 1);
        squares.transform.parent = AreaC.transform;

        float z = -230;
        for (int i = 0; i < 5; ++i)
        {
            tower = createTower(280,z,0,0,0,1);
            tower.transform.parent = AreaC.transform;
            z -= 70;
        }
    }

    void areaD()
    {
        triangle = createTriangle(680, -225);
        triangle.transform.parent = AreaD.transform;
    }

    void areaE()
    {
        squares = createRectangularBuilding(610, 0, 0, 0, 0, 1);
        squares.transform.parent = AreaE.transform;

        squares = createRectangularBuilding(460, 0, 0, 0, 0, 1);
        squares.transform.parent = AreaE.transform;

        squares = createRectangularBuilding(676, 225, 0, 200, 0, 1);
        squares.transform.parent = AreaE.transform;

        squares = createRectangularBuilding(510, 315, 0, 23, 0, 1);
        squares.transform.parent = AreaE.transform;

        squares = createRectangularBuilding(675, 413, 0, 300, 0, 1);
        squares.transform.parent = AreaE.transform;

        h = createCircle(407, 170);
        h.transform.parent = AreaE.transform;
    }

    void areaF()
    {
        squares = createRectangularBuilding(-28, 692, 0, 90, 0, 1);
        squares.transform.parent = AreaF.transform;

        squares = createRectangularBuilding(90, 640, 0, 10, 0, 1);
        squares.transform.parent = AreaF.transform;

        squares = createRectangularBuilding(266, 636, 0, 350, 0, 1);
        squares.transform.parent = AreaF.transform;

        squares = createRectangularBuilding(420, 657, 0, 10, 0, 1);
        squares.transform.parent = AreaF.transform;

        squares = createRectangularBuilding(226, 507, 0, 20, 0, 1);
        squares.transform.parent = AreaF.transform;

        squares = createRectangularBuilding(68, 527, 0, 60, 0, 1);
        squares.transform.parent = AreaF.transform;

        squares = createRectangularBuilding(208, 394, 0, 220, 0, 1);
        squares.transform.parent = AreaF.transform;
    }

    void outsideArea()
    {
        tower = createTower(-250, 570,0, -35, 0, 3);
        tower.transform.parent = outside.transform;

        squares = createRectangularBuilding(-260,240,0,327,0, 2);
        squares.transform.parent = outside.transform;

        squares = createRectangularBuilding(-66,308,0,147,0, 2);
        squares.transform.parent = outside.transform;
    }

    // Position and of a cube where user decide position. 
    void createCube(float x, float z)
    {
        block = (GameObject)Instantiate(Resources.Load("Square", typeof(GameObject)));
        
        int yScale = Random.Range(250, 50);
        float yPos = yScale / 2 + 5;

        block.transform.localScale += new Vector3(50,yScale,50);
        block.transform.position = new Vector3(x, yPos, z);
        block.transform.parent = borders.transform;
    }

    // Position and of circle shape where user decide position.
    GameObject createCircle(float x, float z)
    {
        h = (GameObject)Instantiate(Resources.Load("Circle", typeof(GameObject)));
        h.transform.position = new Vector3(x, 0, z);
        return h; 
    }

    // Position and of a cross shape where user decide position.
    GameObject hospital(float x, float z)
    {
        h = (GameObject)Instantiate(Resources.Load("Hospital", typeof(GameObject)));
        h.transform.position = new Vector3(x, 0, z);
        h.transform.Rotate(0, 35, 0);
        return h;
    }

    // Funcion that create position and of tower prefab where user decide position.
    GameObject createTower(float x, float z, float rotateX, float rotateY, float rotateZ, float scale)
    {
        tower = (GameObject) Instantiate(Resources.Load("Tower", typeof(GameObject)));
        tower.transform.localScale = new Vector3(scale,scale,scale);
        tower.transform.position = new Vector3(x, 0, z);
        tower.transform.Rotate(rotateX, rotateY, rotateZ);

        return tower;
    }

    // Function creates triangle with user input for position. 
    GameObject createTriangle(float x, float z)
    {
        triangle = (GameObject)Instantiate(Resources.Load("Triangle", typeof(GameObject)));
        triangle.transform.localScale = new Vector3(50, 50, 50);
        triangle.transform.position = new Vector3(x, 60, z);

        return triangle;
    }

    // Function creates L-shape building with user input for position. 
    GameObject createRectangularBuilding(float x, float z, float rotateX, float rotateY, float rotateZ, float scale)
    {
        GameObject shapeL = (GameObject)Instantiate(Resources.Load("L_building", typeof(GameObject)));        
        shapeL.transform.localScale = new Vector3(scale, scale, scale);
        shapeL.transform.position = new Vector3(x, 0, z);
        shapeL.transform.Rotate(rotateX,rotateY, rotateZ);

        return shapeL;
    }

    // Function creates first outline borders and
    // each cube is randomly scaled with y-axis from 50 - 250 units. 
    void createBoarders()
    {
        // Diagonal length for part A
        float x = -690;
        float z = -750;
        while (x <= 50)
        {
            createCube(x, z);
            x += 50;
            z += 50;
        }

        // Top border for area A
        z = -700;
        while (z <= -50)
        {
            createCube(-760, z);
            z += 50;
        }

        // Left border for area A
        x = -720;
        while (x <= -100)
        {
            createCube(x, -50);
            x += 50;
        }

        // Inner border for area A
        x = -710;
        z = -620;
        while (x <= -200)
        {
            createCube(x,z);
            x += 50;
            z += 50;
        }

        // Border right side for area B
        x = -720;
        while (x <= -300)
        {
            createCube(x, 50);
            x += 50;
        }

        // Diagonal for area B top-down
        x = -680;
        z = 100;
        while (x <= -490)
        {
            createCube(x, z);
            x += 30;
            z += 50;
        }

        // Diagonal for area B down-top
        x = -320;
        z = 100;
        while (z <= 350)
        {
            createCube(x, z);
            x -= 30;
            z += 50;
        }
        
        // Right side length for area C
        x = -690;
        while (x <= 800)
        {
            createCube(x, -760);
            x += 50;
        }

        // Bottom length for area C
        z = -720;
        while (z <= -510)
        {
            createCube(760, z);
            z += 10;
        }

        // Lower diagonal for area C
        x = 710;
        z = -470;
        while (x >= 200)
        {
            createCube(x, z);
            x -= 50;
            z += 40;
        }

        // Left small part for area C
        x = 160;
        z = -50;
        while (x >= 60)
        {
                createCube(x, z);
            x -= 50;
        }

        //Bottom for area D
        z = -390;
        while (z <= -150)
        {
            createCube(760, z);
            z += 50;
        }

        // Bottom up diagonal for area D
        x = 710;
        z = -340;
        while (z <= -180)
        {
            createCube(x, z);
            x -= 50;
            z += 40;
        }
        createCube(460, -150);

        // Left side for area D
        x = 560;
        while (x <= 710)
        {
            createCube(x, -150);
            x += 50;
        }

       // Diagonal length for part E
        x = 130;
        z = 60;
        while (x <= 750)
        {
            createCube(x, z);
            x += 50;
            z += 50;
        }

        //Right side for area E
        x = 760;
        z = -60;
        int i = 1;
        while (x >= 400)
        {
            if (i <= 3)
            {
                z -= 5;
            }
            createCube(x, z);
            x -= 50;
            i++;
        }

        //Right diagonal upper area E
        x = 360;
        z = -50;
        while (x >= 260)
        {
            createCube(x, z);
            x -= 50;
            z += 50;
        }
        createCube(210, 50);
        createCube(160, 50);

        //Bottom for area E
        z = -20;
        while (z <= 700)
        {
            createCube(760,z);
            z += 50;
        }

        // Upper diagonal for area F
        x = 140;
        z = 220;
        while (z <= 770)
        {
            createCube(x, z);
            x -= 30;
            z += 50;
        }

        //Right side for area F
        x = -140;
        while (x <= 700)
        {
            createCube(x, 770);
            x += 50;
        }

        //Left diagonal bottom-top for area F
        x = 640;
        z = 720;
        while (x >= 100)
        {
            createCube(x, z);
            x -= 50;
            z -= 50;
        }
    }

    // Coroutine that adds delay for each area with 1 second. 
    IEnumerator Start()
    {
        borders = new GameObject();
        borders.transform.name = "Borders";

        createBoarders();

        AreaA = new GameObject();
        AreaA.transform.name = "AreaA";

        AreaB = new GameObject();
        AreaB.transform.name = "AreaB";

        AreaC = new GameObject();
        AreaC.transform.name = "AreaC";

        AreaD = new GameObject();
        AreaD.transform.name = "AreaD";

        AreaE = new GameObject();
        AreaE.transform.name = "AreaE";

        AreaF = new GameObject();
        AreaF.transform.name = "AreaF";

        outside = new GameObject();
        outside.transform.name = "Outside";

        areaA();
        yield return new WaitForSeconds(1);


        areaB();
        yield return new WaitForSeconds(1); 
        
        areaC();
        yield return new WaitForSeconds(1);

        areaD();
        yield return new WaitForSeconds(1);

        areaE();
        yield return new WaitForSeconds(1);

        areaF();
        yield return new WaitForSeconds(1);

        outsideArea();         
    }
}
