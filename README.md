# MG7
## Devlog
Array: I used the _sparrows array in TreeOfBirds to store the four hidden sparrows. I added them in the Inspector and left out Sparrow_Start because it’s already active when the game starts.


Vectors: Each frame, the script loops through the array and uses Vector3.Distance to measure the distance between the player and each inactive bird. Both positions are 3D vectors, so height counts toward the distance. If a bird is within the interaction distance, the script activates it.


Testing: At an interaction distance of 3, only one of the four hidden sparrows came out. I changed it to 6, and all four came out when I walked up to the tree.

## Open-Source Assets
- [Forest Nature Pack](https://kaylousberg.itch.io/kaykit-forest) - environment 3D models
- [Quirky Series](https://assetstore.unity.com/packages/3d/characters/animals/quirky-series-free-animals-pack-178235) - animal 3D models
