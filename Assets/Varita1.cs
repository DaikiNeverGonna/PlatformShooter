using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Varita1 : MonoBehaviour
{
    public Transform firePoint;
    public LineRenderer lineRenderer;

    public bool ShootB;

    private void Start()
    {
        lineRenderer = transform.parent.GetComponent<LineRenderer>();
    }

    public void Update()
    {
        if (ShootB)
        {
            StartCoroutine(Shoot());
            ShootB = false;
        }
    }
    public IEnumerator Shoot()
    {

       RaycastHit2D hitInfo = Physics2D.Raycast(firePoint.position, firePoint.right);

        if (hitInfo)
        {

            Entity entity = hitInfo.transform.GetComponent<Entity>();
            if (entity != null)
            {

                entity.Hurt(1);

            } 

            lineRenderer.SetPosition(0, firePoint.position);
            lineRenderer.SetPosition(1, hitInfo.point);

        }
        else
        {
            lineRenderer.SetPosition(0, firePoint.position);
            lineRenderer.SetPosition(1, firePoint.position + firePoint.right * 100);
        }

        lineRenderer.enabled = true;

        yield return new WaitForSeconds(0.02f);

        lineRenderer.enabled = false;
    }
}
