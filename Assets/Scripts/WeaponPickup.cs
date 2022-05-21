using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ALO
{
    public class WeaponPickup : Interactable
    {

        public WeaponItem weapon;

        public override void Interact(PlayerManager playerManager)
        {
            base.Interact(playerManager);

            PickUpItem(playerManager);
        }

        private void PickUpItem(PlayerManager playerManager)
        {
            PlayerInventory playerInventory;
            PlayerLocomotion playerLocomotion;
            AnimatorHandler animatorHandler;

            playerInventory = playerManager.GetComponent<PlayerInventory>();
            playerLocomotion = playerManager.GetComponent<PlayerLocomotion>();
            animatorHandler = playerManager.GetComponentInChildren<AnimatorHandler>();

            playerLocomotion.rigidBody.velocity = Vector3.zero;
            animatorHandler.PlayTargetAnimation("Taking Item", true);
            playerInventory.weaponsInventory.Add(weapon);

            StartCoroutine(DelayDestroy());
        }

        IEnumerator DelayDestroy()
        {
            yield return new WaitForSeconds(1.5f);

            Destroy(gameObject);
        }
    }
}
