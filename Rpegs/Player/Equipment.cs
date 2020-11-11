using Rpegs.Entities;
using Rpegs.Items;
using Rpegs.PlayerLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Rpegs.BodyParts
{
    public class BodyPart
    {
        public bool IsEmpty => CurrentlyEquipped == null;
        public IWearable CurrentlyEquipped;
    }

    public class Hand
    {
        public bool IsEmpty => CurrentlyEquipped == null;
        public IHandEquipable CurrentlyEquipped = null;
    }
    public class Equipment
    {
        private readonly IHaveInventory _owner;
        public Equipment(IHaveInventory iHaveInventory)
        {
            _owner = iHaveInventory;
        }
        public bool Equip(IHandEquipable item, bool left)
        {
            if (left) //left
            {
                if (LeftHand.IsEmpty)
                {
                    LeftHand.CurrentlyEquipped = (IHandEquipable)item;
                    return true;
                }
                else
                {
                    _owner.Inventory.AddItem((Item)LeftHand.CurrentlyEquipped);
                    LeftHand.CurrentlyEquipped = (IHandEquipable)item;
                    return true;
                }
            }
            else //right
            {
                if (RightHand.IsEmpty)
                {
                    RightHand.CurrentlyEquipped = (IHandEquipable)item;
                    return true;
                }
                else
                {
                    _owner.Inventory.AddItem((Item)RightHand.CurrentlyEquipped);
                    RightHand.CurrentlyEquipped = (IHandEquipable)item;
                    return true;
                }
            }
        }


        public bool Wear(Item item)
        {
            if (item is IWearable)
            {
                switch (item)
                {
                    case IHeadWearable headWearable:
                        if (Head.IsEmpty)
                        {
                            Head.CurrentlyEquipped = headWearable;
                            return true;
                        }
                        else
                        {
                            _owner.Inventory.AddItem((Item)Head.CurrentlyEquipped);
                            Head.CurrentlyEquipped = headWearable;
                            return true;
                        }
                    case IBodyWearable bodyWearable:
                        if (Body.IsEmpty)
                        {
                            Body.CurrentlyEquipped = bodyWearable;
                            return true;
                        }
                        else
                        {
                            _owner.Inventory.AddItem((Item)Body.CurrentlyEquipped);
                            Body.CurrentlyEquipped = bodyWearable;
                            return true;
                        }
                    case ILegsWearable legsWearable:
                        if (Legs.IsEmpty)
                        {
                            Legs.CurrentlyEquipped = legsWearable;
                            return true;
                        }
                        else
                        {
                            _owner.Inventory.AddItem((Item)Legs.CurrentlyEquipped);
                            Legs.CurrentlyEquipped = legsWearable;
                            return true;
                        }
                    case IFootsWearable footsWearable:
                        if (Foots.IsEmpty)
                        {
                            Foots.CurrentlyEquipped = footsWearable;
                            return true;
                        }
                        else
                        {
                            _owner.Inventory.AddItem((Item)Foots.CurrentlyEquipped);
                            Foots.CurrentlyEquipped = footsWearable;
                            return true;
                        }
                    case IHandsWearable handsWearable:
                        if (Hands.IsEmpty)
                        {
                            Hands.CurrentlyEquipped = handsWearable;
                            return true;
                        }
                        else
                        {
                            _owner.Inventory.AddItem((Item)Hands.CurrentlyEquipped);
                            Hands.CurrentlyEquipped = handsWearable;
                            return true;
                        }
                    case IMindWearable mindWearable:
                        if (Mind.IsEmpty)
                        {
                            Mind.CurrentlyEquipped = mindWearable;
                            return true;
                        }
                        else
                        {
                            _owner.Inventory.AddItem((Item)Mind.CurrentlyEquipped);
                            Mind.CurrentlyEquipped = mindWearable;
                            return true;
                        }
                    default:
                        return false;
                }
            }
            else
            {
                return false;
            }
        }

        public Hand LeftHand = new Hand();
        public Hand RightHand = new Hand();

        public BodyPart Body = new BodyPart();

        public BodyPart Legs = new BodyPart();

        public BodyPart Hands = new BodyPart();

        public BodyPart Foots = new BodyPart();

        public BodyPart Head = new BodyPart();

        public BodyPart Mind = new BodyPart();
    }
}
