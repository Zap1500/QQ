using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseCursor : MonoBehaviour
{

    public Texture2D cursor;
    public Texture2D cursorClicked;
    public Texture2D cursorSoap;

    //bubble prefab
    [SerializeField] GameObject triBubble = null;

    public Vector2 mousePosition;

    private CursorControls controls;
    private Camera mainCamera;
    // for holding soap
    private bool locked = false;

    private void Awake() {
        controls = new CursorControls();
        ChangeCursor(cursor);
        Cursor.lockState = CursorLockMode.Confined;
        mainCamera = Camera.main;
        //mousePos = new Vector3();
    }
    // handlers for cursor controls
    private void OnEnable() {
        controls.Enable();
    }
    private void OnDisable()
    {
        controls.Disable();
    }

    // detecting what is being clicked
    private void DetectObject() {
        //Debug.Log("Test");
        Ray ray = mainCamera.ScreenPointToRay(controls.BathTime.Position.ReadValue<Vector2>());
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit)) {
            if (hit.collider != null) {
                Debug.Log("3D Hit: " + hit.collider.tag);
            }
        }
        /*
        RaycastHit2D hits2D = Physics2D.GetRayIntersection(ray);
        if (hits2D.collider != null) {
            Debug.Log("2D Hit: " + hits2D.collider.tag);
        } */
        RaycastHit2D[] hits2DAll = Physics2D.GetRayIntersectionAll(ray);
        for (int i = 0; i< hits2DAll.Length; i++) {
            if (hits2DAll[i].collider != null)
            {
                //IClicker clicker = hits2DAll[i].collider.GetComponent<IClicker>();
                // if (clicker != null) { 
                //     clicker.onClickAction; 
                // }

                if (hits2DAll[i].collider.tag == "Soap") {
                    hits2DAll[i].collider.gameObject.GetComponent<Soap>().onClickAction();
                    ChangeCursor(cursorSoap);
                    locked = true;
                }
                if (hits2DAll[i].collider.tag == "Pet")
                {
                    hits2DAll[i].collider.gameObject.GetComponent<Pet>().onClickAction();
                    if (locked)
                    {
                        Debug.Log("CreatingBubbles");
                        Instantiate(triBubble, hits2DAll[i].point, Quaternion.identity);
                    }
                }
                if (hits2DAll[i].collider.tag == "ShowerHead")
                {
                    hits2DAll[i].collider.gameObject.GetComponent<ShowerHead>().onClickAction();
                }
                

                //Debug.Log("2D Hit All: " + hits2DAll[i].collider.tag);
            }
        }
/*
        RaycastHit2D[] hits2DAllNonAlloc = new RaycastHit2D[1];
        int numberOfHits2D = Physics2D.GetRayIntersectionNonAlloc(ray, hits2DAllNonAlloc);
        for (int i = 0; i < hits2DAll.Length; i++)
        {
            if (hits2DAll[i].collider != null)
            {
                Debug.Log("2D Hit All Non Alloc: " + hits2DAll[i].collider.tag);
            }
        } */
    }

    private void ChangeCursor(Texture2D cursorType) {
        Cursor.SetCursor(cursorType, Vector2.zero, CursorMode.Auto);
    }
    // changes cursor when clicking *needs secondary arrow 
    private void Start() {
        //Cursor.visible = false;
        controls.BathTime.LeftClick.started += _ => StartedClick();
        controls.BathTime.LeftClick.performed += _ => EndedClick();

        controls.BathTime.RightClick.started += _ => StartedClick2();
        controls.BathTime.RightClick.performed += _ => EndedClick2();
    }

    private void StartedClick() {
        if (!locked) {
                ChangeCursor(cursorClicked);
            }
        else {
            DetectObject();
            //Instantiate(triBubble, mousePosition, Quaternion.identity);
        }
    }
    private void EndedClick() {
        if (!locked) {
            ChangeCursor(cursor);
            DetectObject();
        }
    }

    private void StartedClick2()
    {
        ChangeCursor(cursorSoap);
    }
    private void EndedClick2()
    {
        ChangeCursor(cursor);
        locked = false;
        //recreate soap spawn
        //Instansiate();
    }
    // Update is called once per frame and not being used for this
    void Update()
    {
        //mousePosition = Camera.main.ScreenToViewportPoint(controls.BathTime.Position);
        //Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //transform.position = cursorPos;
    }
}
