using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lootbag : MonoBehaviour
{
    public GameObject droppedItemPrefab;
    public List<loot> lootList = new List<loot>();


    loot GetDroppeditems()
    {
        int randomNumber = Random.Range(1,101);
        List<loot> possibleItems = new List<loot>();
        foreach(loot item in lootList)
        {
            if(randomNumber <= item.dropChance)
            {
                possibleItems.Add(item);
                
            }
        }
        if(possibleItems.Count >  0)
        {
            loot dropItem = possibleItems[Random.Range(0,possibleItems.Count)];
            return dropItem;

        }
        return null;
    }
    public void InstantiateLoot(Vector3 spawnPosition)
    {
        loot droppedItem = GetDroppeditems();
        if(droppedItem !=null)
        {
            GameObject lootGameObject = Instantiate(droppedItemPrefab , spawnPosition, Quaternion.identity);
            lootGameObject.GetComponent<SpriteRenderer>().sprite = droppedItem.lootSprite;

            float dropForce = 300f;
            Vector2 dropDirection = new Vector2(Random.Range(-1f,1f),Random.Range(-1f,1f));
            lootGameObject.GetComponent<Rigidbody2D>().AddForce(dropDirection*dropForce,ForceMode2D.Impulse);
        }
    }
    
}

