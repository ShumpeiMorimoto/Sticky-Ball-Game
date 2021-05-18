using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class hiddenwall : MonoBehaviour
{
    [SerializeField]
    private Transform subject_;

    [SerializeField]
    private List<string> coverLayerNameList_;

    private int layerMask_;

    public List<Renderer> rendererHitsList_ = new List<Renderer>();

    public Renderer[] rendererHitsPrevs_;
    // Start is called before the first frame update
    void Start()
    {
        layerMask_ = 0;
        foreach (string _layerName in coverLayerNameList_)
        {
            layerMask_ |= 1 << LayerMask.NameToLayer(_layerName);
        }
    }

    // Update is called once per frame
    void Update()
    {
            Vector3 _difference = (subject_.transform.position - this.transform.position);
            Vector3 _direction = _difference.normalized;
            Ray _ray = new Ray(this.transform.position, _direction);

            RaycastHit[] _hits = Physics.RaycastAll(_ray, _difference.magnitude, layerMask_);

            rendererHitsPrevs_ = rendererHitsList_.ToArray();
            rendererHitsList_.Clear();

            foreach (RaycastHit _hit in _hits)
            {
                
                if (_hit.collider.gameObject == subject_)
                {
                    continue;
                }

                
                Renderer _renderer = _hit.collider.gameObject.GetComponent<Renderer>();
                if (_renderer != null)
                {
                    rendererHitsList_.Add(_renderer);
                    _renderer.enabled = false;
                }
            }

            foreach (Renderer _renderer in rendererHitsPrevs_.Except<Renderer>(rendererHitsList_))
            {
                
                if (_renderer != null)
                {
                    _renderer.enabled = true;
                }
            }

        }
    }
