using UnityEngine;

public class Player
{
    [SerializeField]
    private int id;

    [SerializeField]
    private Color color;

    [SerializeField]
    private int money;

    [SerializeField]
    private Tile[] ownedPropreties;

    public int GetId() {
        return id;
    }

    public void SetId(int newId) {
        id = newId;
    }

    public Color GetColor() {
        return color;
    }

    public void SetColor(Color c) {
        color = c;
    }
}