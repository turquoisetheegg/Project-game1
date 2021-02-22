using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;



public class PlayerInputHandler2 : MonoBehaviour
{
    

    [SerializeField]
    public Mover2 mover;


    //Cooldown var
    public float cooldownTime = 2;
    private float nextFireTime = 0;
    private bool button;
    //Input Asset


    public void OnMove(CallbackContext context)
    {
        if (mover != null && button == false)
            mover.SetInputVector(context.ReadValue<Vector2>());
        else
            mover.SetInputVector(Vector2.zero);


    }

    public void OnRotate(CallbackContext context)
    {
        if (mover != null)
            mover.SetInputVectorRot(context.ReadValue<Vector2>());
        
        
    }







    //shoot methods

    public void OnShoot(InputAction.CallbackContext context)
    {

        if (mover != null && context.started)
            button = context.ReadValueAsButton();


        if (mover != null && context.canceled)
        {
            button = context.ReadValueAsButton();
            mover.CancelBullet();
        }

    }


    public void OnShoot2(InputAction.CallbackContext context)
    {

        if (mover != null && context.started)
            button = context.ReadValueAsButton();


        if (mover != null && context.canceled)
        {
            button = context.ReadValueAsButton();
            mover.CancelBullet2();
        }

    }




    //Shields methods


    public void OnShield(InputAction.CallbackContext context)
    {
        if (Time.time > nextFireTime)
        {
            if (mover != null && context.performed)
            {
                mover.Shield1black();
                nextFireTime = Time.time + cooldownTime;

            }
        }



    }


    public void OnShield2(InputAction.CallbackContext context)
    {
        if (Time.time > nextFireTime)
        {
            if (mover != null && context.performed)
            {
                mover.Shield1white();
                nextFireTime = Time.time + cooldownTime;

            }
        }



    }





}
