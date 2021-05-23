namespace SimpleECS
{
    using SimpleECS.Internal;

    public partial struct Entity
    {
        /// <summary>
        /// Creates an Entity with supplied Components, can add up to 64 components
        /// </summary>
        public static Entity Create() => Sig.archetype.CreateEntity();
        public static Entity Create<C1>(
        C1 c1)
        {
            ref var archetype = ref Sig<C1>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1)));
            return archetype.CreateEntity().Set(c1);
        }

        public static Entity Create<C1, C2>(
        C1 c1, C2 c2)
        {
            ref var archetype = ref Sig<C1, C2>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2)));
            return archetype.CreateEntity().Set(c1).Set(c2);
        }

        public static Entity Create<C1, C2, C3>(
        C1 c1, C2 c2, C3 c3)
        {
            ref var archetype = ref Sig<C1, C2, C3>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3);
        }

        public static Entity Create<C1, C2, C3, C4>(
        C1 c1, C2 c2, C3 c3, C4 c4)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4);
        }

        public static Entity Create<C1, C2, C3, C4, C5>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26, C27 c27)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26), typeof(C27)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26).Set(c27);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26, C27 c27, C28 c28)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26), typeof(C27), typeof(C28)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26).Set(c27).Set(c28);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26, C27 c27, C28 c28, C29 c29)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26), typeof(C27), typeof(C28), typeof(C29)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26).Set(c27).Set(c28).Set(c29);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26, C27 c27, C28 c28, C29 c29, C30 c30)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26), typeof(C27), typeof(C28), typeof(C29), typeof(C30)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26).Set(c27).Set(c28).Set(c29).Set(c30);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26, C27 c27, C28 c28, C29 c29, C30 c30, C31 c31)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26), typeof(C27), typeof(C28), typeof(C29), typeof(C30), typeof(C31)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26).Set(c27).Set(c28).Set(c29).Set(c30).Set(c31);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26, C27 c27, C28 c28, C29 c29, C30 c30, C31 c31, C32 c32)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26), typeof(C27), typeof(C28), typeof(C29), typeof(C30), typeof(C31), typeof(C32)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26).Set(c27).Set(c28).Set(c29).Set(c30).Set(c31).Set(c32);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26, C27 c27, C28 c28, C29 c29, C30 c30, C31 c31, C32 c32, C33 c33)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26), typeof(C27), typeof(C28), typeof(C29), typeof(C30), typeof(C31), typeof(C32), typeof(C33)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26).Set(c27).Set(c28).Set(c29).Set(c30).Set(c31).Set(c32).Set(c33);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26, C27 c27, C28 c28, C29 c29, C30 c30, C31 c31, C32 c32, C33 c33, C34 c34)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26), typeof(C27), typeof(C28), typeof(C29), typeof(C30), typeof(C31), typeof(C32), typeof(C33), typeof(C34)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26).Set(c27).Set(c28).Set(c29).Set(c30).Set(c31).Set(c32).Set(c33).Set(c34);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26, C27 c27, C28 c28, C29 c29, C30 c30, C31 c31, C32 c32, C33 c33, C34 c34, C35 c35)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26), typeof(C27), typeof(C28), typeof(C29), typeof(C30), typeof(C31), typeof(C32), typeof(C33), typeof(C34), typeof(C35)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26).Set(c27).Set(c28).Set(c29).Set(c30).Set(c31).Set(c32).Set(c33).Set(c34).Set(c35);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26, C27 c27, C28 c28, C29 c29, C30 c30, C31 c31, C32 c32, C33 c33, C34 c34, C35 c35, C36 c36)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26), typeof(C27), typeof(C28), typeof(C29), typeof(C30), typeof(C31), typeof(C32), typeof(C33), typeof(C34), typeof(C35), typeof(C36)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26).Set(c27).Set(c28).Set(c29).Set(c30).Set(c31).Set(c32).Set(c33).Set(c34).Set(c35).Set(c36);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26, C27 c27, C28 c28, C29 c29, C30 c30, C31 c31, C32 c32, C33 c33, C34 c34, C35 c35, C36 c36, C37 c37)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26), typeof(C27), typeof(C28), typeof(C29), typeof(C30), typeof(C31), typeof(C32), typeof(C33), typeof(C34), typeof(C35), typeof(C36), typeof(C37)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26).Set(c27).Set(c28).Set(c29).Set(c30).Set(c31).Set(c32).Set(c33).Set(c34).Set(c35).Set(c36).Set(c37);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26, C27 c27, C28 c28, C29 c29, C30 c30, C31 c31, C32 c32, C33 c33, C34 c34, C35 c35, C36 c36, C37 c37, C38 c38)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26), typeof(C27), typeof(C28), typeof(C29), typeof(C30), typeof(C31), typeof(C32), typeof(C33), typeof(C34), typeof(C35), typeof(C36), typeof(C37), typeof(C38)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26).Set(c27).Set(c28).Set(c29).Set(c30).Set(c31).Set(c32).Set(c33).Set(c34).Set(c35).Set(c36).Set(c37).Set(c38);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26, C27 c27, C28 c28, C29 c29, C30 c30, C31 c31, C32 c32, C33 c33, C34 c34, C35 c35, C36 c36, C37 c37, C38 c38, C39 c39)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26), typeof(C27), typeof(C28), typeof(C29), typeof(C30), typeof(C31), typeof(C32), typeof(C33), typeof(C34), typeof(C35), typeof(C36), typeof(C37), typeof(C38), typeof(C39)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26).Set(c27).Set(c28).Set(c29).Set(c30).Set(c31).Set(c32).Set(c33).Set(c34).Set(c35).Set(c36).Set(c37).Set(c38).Set(c39);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26, C27 c27, C28 c28, C29 c29, C30 c30, C31 c31, C32 c32, C33 c33, C34 c34, C35 c35, C36 c36, C37 c37, C38 c38, C39 c39, C40 c40)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26), typeof(C27), typeof(C28), typeof(C29), typeof(C30), typeof(C31), typeof(C32), typeof(C33), typeof(C34), typeof(C35), typeof(C36), typeof(C37), typeof(C38), typeof(C39), typeof(C40)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26).Set(c27).Set(c28).Set(c29).Set(c30).Set(c31).Set(c32).Set(c33).Set(c34).Set(c35).Set(c36).Set(c37).Set(c38).Set(c39).Set(c40);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26, C27 c27, C28 c28, C29 c29, C30 c30, C31 c31, C32 c32, C33 c33, C34 c34, C35 c35, C36 c36, C37 c37, C38 c38, C39 c39, C40 c40, C41 c41)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26), typeof(C27), typeof(C28), typeof(C29), typeof(C30), typeof(C31), typeof(C32), typeof(C33), typeof(C34), typeof(C35), typeof(C36), typeof(C37), typeof(C38), typeof(C39), typeof(C40), typeof(C41)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26).Set(c27).Set(c28).Set(c29).Set(c30).Set(c31).Set(c32).Set(c33).Set(c34).Set(c35).Set(c36).Set(c37).Set(c38).Set(c39).Set(c40).Set(c41);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26, C27 c27, C28 c28, C29 c29, C30 c30, C31 c31, C32 c32, C33 c33, C34 c34, C35 c35, C36 c36, C37 c37, C38 c38, C39 c39, C40 c40, C41 c41, C42 c42)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26), typeof(C27), typeof(C28), typeof(C29), typeof(C30), typeof(C31), typeof(C32), typeof(C33), typeof(C34), typeof(C35), typeof(C36), typeof(C37), typeof(C38), typeof(C39), typeof(C40), typeof(C41), typeof(C42)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26).Set(c27).Set(c28).Set(c29).Set(c30).Set(c31).Set(c32).Set(c33).Set(c34).Set(c35).Set(c36).Set(c37).Set(c38).Set(c39).Set(c40).Set(c41).Set(c42);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26, C27 c27, C28 c28, C29 c29, C30 c30, C31 c31, C32 c32, C33 c33, C34 c34, C35 c35, C36 c36, C37 c37, C38 c38, C39 c39, C40 c40, C41 c41, C42 c42, C43 c43)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26), typeof(C27), typeof(C28), typeof(C29), typeof(C30), typeof(C31), typeof(C32), typeof(C33), typeof(C34), typeof(C35), typeof(C36), typeof(C37), typeof(C38), typeof(C39), typeof(C40), typeof(C41), typeof(C42), typeof(C43)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26).Set(c27).Set(c28).Set(c29).Set(c30).Set(c31).Set(c32).Set(c33).Set(c34).Set(c35).Set(c36).Set(c37).Set(c38).Set(c39).Set(c40).Set(c41).Set(c42).Set(c43);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26, C27 c27, C28 c28, C29 c29, C30 c30, C31 c31, C32 c32, C33 c33, C34 c34, C35 c35, C36 c36, C37 c37, C38 c38, C39 c39, C40 c40, C41 c41, C42 c42, C43 c43, C44 c44)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26), typeof(C27), typeof(C28), typeof(C29), typeof(C30), typeof(C31), typeof(C32), typeof(C33), typeof(C34), typeof(C35), typeof(C36), typeof(C37), typeof(C38), typeof(C39), typeof(C40), typeof(C41), typeof(C42), typeof(C43), typeof(C44)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26).Set(c27).Set(c28).Set(c29).Set(c30).Set(c31).Set(c32).Set(c33).Set(c34).Set(c35).Set(c36).Set(c37).Set(c38).Set(c39).Set(c40).Set(c41).Set(c42).Set(c43).Set(c44);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26, C27 c27, C28 c28, C29 c29, C30 c30, C31 c31, C32 c32, C33 c33, C34 c34, C35 c35, C36 c36, C37 c37, C38 c38, C39 c39, C40 c40, C41 c41, C42 c42, C43 c43, C44 c44, C45 c45)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26), typeof(C27), typeof(C28), typeof(C29), typeof(C30), typeof(C31), typeof(C32), typeof(C33), typeof(C34), typeof(C35), typeof(C36), typeof(C37), typeof(C38), typeof(C39), typeof(C40), typeof(C41), typeof(C42), typeof(C43), typeof(C44), typeof(C45)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26).Set(c27).Set(c28).Set(c29).Set(c30).Set(c31).Set(c32).Set(c33).Set(c34).Set(c35).Set(c36).Set(c37).Set(c38).Set(c39).Set(c40).Set(c41).Set(c42).Set(c43).Set(c44).Set(c45);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26, C27 c27, C28 c28, C29 c29, C30 c30, C31 c31, C32 c32, C33 c33, C34 c34, C35 c35, C36 c36, C37 c37, C38 c38, C39 c39, C40 c40, C41 c41, C42 c42, C43 c43, C44 c44, C45 c45, C46 c46)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26), typeof(C27), typeof(C28), typeof(C29), typeof(C30), typeof(C31), typeof(C32), typeof(C33), typeof(C34), typeof(C35), typeof(C36), typeof(C37), typeof(C38), typeof(C39), typeof(C40), typeof(C41), typeof(C42), typeof(C43), typeof(C44), typeof(C45), typeof(C46)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26).Set(c27).Set(c28).Set(c29).Set(c30).Set(c31).Set(c32).Set(c33).Set(c34).Set(c35).Set(c36).Set(c37).Set(c38).Set(c39).Set(c40).Set(c41).Set(c42).Set(c43).Set(c44).Set(c45).Set(c46);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26, C27 c27, C28 c28, C29 c29, C30 c30, C31 c31, C32 c32, C33 c33, C34 c34, C35 c35, C36 c36, C37 c37, C38 c38, C39 c39, C40 c40, C41 c41, C42 c42, C43 c43, C44 c44, C45 c45, C46 c46, C47 c47)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26), typeof(C27), typeof(C28), typeof(C29), typeof(C30), typeof(C31), typeof(C32), typeof(C33), typeof(C34), typeof(C35), typeof(C36), typeof(C37), typeof(C38), typeof(C39), typeof(C40), typeof(C41), typeof(C42), typeof(C43), typeof(C44), typeof(C45), typeof(C46), typeof(C47)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26).Set(c27).Set(c28).Set(c29).Set(c30).Set(c31).Set(c32).Set(c33).Set(c34).Set(c35).Set(c36).Set(c37).Set(c38).Set(c39).Set(c40).Set(c41).Set(c42).Set(c43).Set(c44).Set(c45).Set(c46).Set(c47);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26, C27 c27, C28 c28, C29 c29, C30 c30, C31 c31, C32 c32, C33 c33, C34 c34, C35 c35, C36 c36, C37 c37, C38 c38, C39 c39, C40 c40, C41 c41, C42 c42, C43 c43, C44 c44, C45 c45, C46 c46, C47 c47, C48 c48)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26), typeof(C27), typeof(C28), typeof(C29), typeof(C30), typeof(C31), typeof(C32), typeof(C33), typeof(C34), typeof(C35), typeof(C36), typeof(C37), typeof(C38), typeof(C39), typeof(C40), typeof(C41), typeof(C42), typeof(C43), typeof(C44), typeof(C45), typeof(C46), typeof(C47), typeof(C48)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26).Set(c27).Set(c28).Set(c29).Set(c30).Set(c31).Set(c32).Set(c33).Set(c34).Set(c35).Set(c36).Set(c37).Set(c38).Set(c39).Set(c40).Set(c41).Set(c42).Set(c43).Set(c44).Set(c45).Set(c46).Set(c47).Set(c48);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26, C27 c27, C28 c28, C29 c29, C30 c30, C31 c31, C32 c32, C33 c33, C34 c34, C35 c35, C36 c36, C37 c37, C38 c38, C39 c39, C40 c40, C41 c41, C42 c42, C43 c43, C44 c44, C45 c45, C46 c46, C47 c47, C48 c48, C49 c49)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26), typeof(C27), typeof(C28), typeof(C29), typeof(C30), typeof(C31), typeof(C32), typeof(C33), typeof(C34), typeof(C35), typeof(C36), typeof(C37), typeof(C38), typeof(C39), typeof(C40), typeof(C41), typeof(C42), typeof(C43), typeof(C44), typeof(C45), typeof(C46), typeof(C47), typeof(C48), typeof(C49)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26).Set(c27).Set(c28).Set(c29).Set(c30).Set(c31).Set(c32).Set(c33).Set(c34).Set(c35).Set(c36).Set(c37).Set(c38).Set(c39).Set(c40).Set(c41).Set(c42).Set(c43).Set(c44).Set(c45).Set(c46).Set(c47).Set(c48).Set(c49);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26, C27 c27, C28 c28, C29 c29, C30 c30, C31 c31, C32 c32, C33 c33, C34 c34, C35 c35, C36 c36, C37 c37, C38 c38, C39 c39, C40 c40, C41 c41, C42 c42, C43 c43, C44 c44, C45 c45, C46 c46, C47 c47, C48 c48, C49 c49, C50 c50)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26), typeof(C27), typeof(C28), typeof(C29), typeof(C30), typeof(C31), typeof(C32), typeof(C33), typeof(C34), typeof(C35), typeof(C36), typeof(C37), typeof(C38), typeof(C39), typeof(C40), typeof(C41), typeof(C42), typeof(C43), typeof(C44), typeof(C45), typeof(C46), typeof(C47), typeof(C48), typeof(C49), typeof(C50)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26).Set(c27).Set(c28).Set(c29).Set(c30).Set(c31).Set(c32).Set(c33).Set(c34).Set(c35).Set(c36).Set(c37).Set(c38).Set(c39).Set(c40).Set(c41).Set(c42).Set(c43).Set(c44).Set(c45).Set(c46).Set(c47).Set(c48).Set(c49).Set(c50);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26, C27 c27, C28 c28, C29 c29, C30 c30, C31 c31, C32 c32, C33 c33, C34 c34, C35 c35, C36 c36, C37 c37, C38 c38, C39 c39, C40 c40, C41 c41, C42 c42, C43 c43, C44 c44, C45 c45, C46 c46, C47 c47, C48 c48, C49 c49, C50 c50, C51 c51)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26), typeof(C27), typeof(C28), typeof(C29), typeof(C30), typeof(C31), typeof(C32), typeof(C33), typeof(C34), typeof(C35), typeof(C36), typeof(C37), typeof(C38), typeof(C39), typeof(C40), typeof(C41), typeof(C42), typeof(C43), typeof(C44), typeof(C45), typeof(C46), typeof(C47), typeof(C48), typeof(C49), typeof(C50), typeof(C51)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26).Set(c27).Set(c28).Set(c29).Set(c30).Set(c31).Set(c32).Set(c33).Set(c34).Set(c35).Set(c36).Set(c37).Set(c38).Set(c39).Set(c40).Set(c41).Set(c42).Set(c43).Set(c44).Set(c45).Set(c46).Set(c47).Set(c48).Set(c49).Set(c50).Set(c51);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26, C27 c27, C28 c28, C29 c29, C30 c30, C31 c31, C32 c32, C33 c33, C34 c34, C35 c35, C36 c36, C37 c37, C38 c38, C39 c39, C40 c40, C41 c41, C42 c42, C43 c43, C44 c44, C45 c45, C46 c46, C47 c47, C48 c48, C49 c49, C50 c50, C51 c51, C52 c52)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26), typeof(C27), typeof(C28), typeof(C29), typeof(C30), typeof(C31), typeof(C32), typeof(C33), typeof(C34), typeof(C35), typeof(C36), typeof(C37), typeof(C38), typeof(C39), typeof(C40), typeof(C41), typeof(C42), typeof(C43), typeof(C44), typeof(C45), typeof(C46), typeof(C47), typeof(C48), typeof(C49), typeof(C50), typeof(C51), typeof(C52)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26).Set(c27).Set(c28).Set(c29).Set(c30).Set(c31).Set(c32).Set(c33).Set(c34).Set(c35).Set(c36).Set(c37).Set(c38).Set(c39).Set(c40).Set(c41).Set(c42).Set(c43).Set(c44).Set(c45).Set(c46).Set(c47).Set(c48).Set(c49).Set(c50).Set(c51).Set(c52);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52, C53>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26, C27 c27, C28 c28, C29 c29, C30 c30, C31 c31, C32 c32, C33 c33, C34 c34, C35 c35, C36 c36, C37 c37, C38 c38, C39 c39, C40 c40, C41 c41, C42 c42, C43 c43, C44 c44, C45 c45, C46 c46, C47 c47, C48 c48, C49 c49, C50 c50, C51 c51, C52 c52, C53 c53)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52, C53>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26), typeof(C27), typeof(C28), typeof(C29), typeof(C30), typeof(C31), typeof(C32), typeof(C33), typeof(C34), typeof(C35), typeof(C36), typeof(C37), typeof(C38), typeof(C39), typeof(C40), typeof(C41), typeof(C42), typeof(C43), typeof(C44), typeof(C45), typeof(C46), typeof(C47), typeof(C48), typeof(C49), typeof(C50), typeof(C51), typeof(C52), typeof(C53)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26).Set(c27).Set(c28).Set(c29).Set(c30).Set(c31).Set(c32).Set(c33).Set(c34).Set(c35).Set(c36).Set(c37).Set(c38).Set(c39).Set(c40).Set(c41).Set(c42).Set(c43).Set(c44).Set(c45).Set(c46).Set(c47).Set(c48).Set(c49).Set(c50).Set(c51).Set(c52).Set(c53);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52, C53, C54>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26, C27 c27, C28 c28, C29 c29, C30 c30, C31 c31, C32 c32, C33 c33, C34 c34, C35 c35, C36 c36, C37 c37, C38 c38, C39 c39, C40 c40, C41 c41, C42 c42, C43 c43, C44 c44, C45 c45, C46 c46, C47 c47, C48 c48, C49 c49, C50 c50, C51 c51, C52 c52, C53 c53, C54 c54)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52, C53, C54>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26), typeof(C27), typeof(C28), typeof(C29), typeof(C30), typeof(C31), typeof(C32), typeof(C33), typeof(C34), typeof(C35), typeof(C36), typeof(C37), typeof(C38), typeof(C39), typeof(C40), typeof(C41), typeof(C42), typeof(C43), typeof(C44), typeof(C45), typeof(C46), typeof(C47), typeof(C48), typeof(C49), typeof(C50), typeof(C51), typeof(C52), typeof(C53), typeof(C54)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26).Set(c27).Set(c28).Set(c29).Set(c30).Set(c31).Set(c32).Set(c33).Set(c34).Set(c35).Set(c36).Set(c37).Set(c38).Set(c39).Set(c40).Set(c41).Set(c42).Set(c43).Set(c44).Set(c45).Set(c46).Set(c47).Set(c48).Set(c49).Set(c50).Set(c51).Set(c52).Set(c53).Set(c54);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52, C53, C54, C55>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26, C27 c27, C28 c28, C29 c29, C30 c30, C31 c31, C32 c32, C33 c33, C34 c34, C35 c35, C36 c36, C37 c37, C38 c38, C39 c39, C40 c40, C41 c41, C42 c42, C43 c43, C44 c44, C45 c45, C46 c46, C47 c47, C48 c48, C49 c49, C50 c50, C51 c51, C52 c52, C53 c53, C54 c54, C55 c55)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52, C53, C54, C55>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26), typeof(C27), typeof(C28), typeof(C29), typeof(C30), typeof(C31), typeof(C32), typeof(C33), typeof(C34), typeof(C35), typeof(C36), typeof(C37), typeof(C38), typeof(C39), typeof(C40), typeof(C41), typeof(C42), typeof(C43), typeof(C44), typeof(C45), typeof(C46), typeof(C47), typeof(C48), typeof(C49), typeof(C50), typeof(C51), typeof(C52), typeof(C53), typeof(C54), typeof(C55)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26).Set(c27).Set(c28).Set(c29).Set(c30).Set(c31).Set(c32).Set(c33).Set(c34).Set(c35).Set(c36).Set(c37).Set(c38).Set(c39).Set(c40).Set(c41).Set(c42).Set(c43).Set(c44).Set(c45).Set(c46).Set(c47).Set(c48).Set(c49).Set(c50).Set(c51).Set(c52).Set(c53).Set(c54).Set(c55);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52, C53, C54, C55, C56>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26, C27 c27, C28 c28, C29 c29, C30 c30, C31 c31, C32 c32, C33 c33, C34 c34, C35 c35, C36 c36, C37 c37, C38 c38, C39 c39, C40 c40, C41 c41, C42 c42, C43 c43, C44 c44, C45 c45, C46 c46, C47 c47, C48 c48, C49 c49, C50 c50, C51 c51, C52 c52, C53 c53, C54 c54, C55 c55, C56 c56)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52, C53, C54, C55, C56>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26), typeof(C27), typeof(C28), typeof(C29), typeof(C30), typeof(C31), typeof(C32), typeof(C33), typeof(C34), typeof(C35), typeof(C36), typeof(C37), typeof(C38), typeof(C39), typeof(C40), typeof(C41), typeof(C42), typeof(C43), typeof(C44), typeof(C45), typeof(C46), typeof(C47), typeof(C48), typeof(C49), typeof(C50), typeof(C51), typeof(C52), typeof(C53), typeof(C54), typeof(C55), typeof(C56)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26).Set(c27).Set(c28).Set(c29).Set(c30).Set(c31).Set(c32).Set(c33).Set(c34).Set(c35).Set(c36).Set(c37).Set(c38).Set(c39).Set(c40).Set(c41).Set(c42).Set(c43).Set(c44).Set(c45).Set(c46).Set(c47).Set(c48).Set(c49).Set(c50).Set(c51).Set(c52).Set(c53).Set(c54).Set(c55).Set(c56);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52, C53, C54, C55, C56, C57>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26, C27 c27, C28 c28, C29 c29, C30 c30, C31 c31, C32 c32, C33 c33, C34 c34, C35 c35, C36 c36, C37 c37, C38 c38, C39 c39, C40 c40, C41 c41, C42 c42, C43 c43, C44 c44, C45 c45, C46 c46, C47 c47, C48 c48, C49 c49, C50 c50, C51 c51, C52 c52, C53 c53, C54 c54, C55 c55, C56 c56, C57 c57)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52, C53, C54, C55, C56, C57>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26), typeof(C27), typeof(C28), typeof(C29), typeof(C30), typeof(C31), typeof(C32), typeof(C33), typeof(C34), typeof(C35), typeof(C36), typeof(C37), typeof(C38), typeof(C39), typeof(C40), typeof(C41), typeof(C42), typeof(C43), typeof(C44), typeof(C45), typeof(C46), typeof(C47), typeof(C48), typeof(C49), typeof(C50), typeof(C51), typeof(C52), typeof(C53), typeof(C54), typeof(C55), typeof(C56), typeof(C57)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26).Set(c27).Set(c28).Set(c29).Set(c30).Set(c31).Set(c32).Set(c33).Set(c34).Set(c35).Set(c36).Set(c37).Set(c38).Set(c39).Set(c40).Set(c41).Set(c42).Set(c43).Set(c44).Set(c45).Set(c46).Set(c47).Set(c48).Set(c49).Set(c50).Set(c51).Set(c52).Set(c53).Set(c54).Set(c55).Set(c56).Set(c57);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52, C53, C54, C55, C56, C57, C58>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26, C27 c27, C28 c28, C29 c29, C30 c30, C31 c31, C32 c32, C33 c33, C34 c34, C35 c35, C36 c36, C37 c37, C38 c38, C39 c39, C40 c40, C41 c41, C42 c42, C43 c43, C44 c44, C45 c45, C46 c46, C47 c47, C48 c48, C49 c49, C50 c50, C51 c51, C52 c52, C53 c53, C54 c54, C55 c55, C56 c56, C57 c57, C58 c58)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52, C53, C54, C55, C56, C57, C58>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26), typeof(C27), typeof(C28), typeof(C29), typeof(C30), typeof(C31), typeof(C32), typeof(C33), typeof(C34), typeof(C35), typeof(C36), typeof(C37), typeof(C38), typeof(C39), typeof(C40), typeof(C41), typeof(C42), typeof(C43), typeof(C44), typeof(C45), typeof(C46), typeof(C47), typeof(C48), typeof(C49), typeof(C50), typeof(C51), typeof(C52), typeof(C53), typeof(C54), typeof(C55), typeof(C56), typeof(C57), typeof(C58)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26).Set(c27).Set(c28).Set(c29).Set(c30).Set(c31).Set(c32).Set(c33).Set(c34).Set(c35).Set(c36).Set(c37).Set(c38).Set(c39).Set(c40).Set(c41).Set(c42).Set(c43).Set(c44).Set(c45).Set(c46).Set(c47).Set(c48).Set(c49).Set(c50).Set(c51).Set(c52).Set(c53).Set(c54).Set(c55).Set(c56).Set(c57).Set(c58);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52, C53, C54, C55, C56, C57, C58, C59>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26, C27 c27, C28 c28, C29 c29, C30 c30, C31 c31, C32 c32, C33 c33, C34 c34, C35 c35, C36 c36, C37 c37, C38 c38, C39 c39, C40 c40, C41 c41, C42 c42, C43 c43, C44 c44, C45 c45, C46 c46, C47 c47, C48 c48, C49 c49, C50 c50, C51 c51, C52 c52, C53 c53, C54 c54, C55 c55, C56 c56, C57 c57, C58 c58, C59 c59)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52, C53, C54, C55, C56, C57, C58, C59>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26), typeof(C27), typeof(C28), typeof(C29), typeof(C30), typeof(C31), typeof(C32), typeof(C33), typeof(C34), typeof(C35), typeof(C36), typeof(C37), typeof(C38), typeof(C39), typeof(C40), typeof(C41), typeof(C42), typeof(C43), typeof(C44), typeof(C45), typeof(C46), typeof(C47), typeof(C48), typeof(C49), typeof(C50), typeof(C51), typeof(C52), typeof(C53), typeof(C54), typeof(C55), typeof(C56), typeof(C57), typeof(C58), typeof(C59)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26).Set(c27).Set(c28).Set(c29).Set(c30).Set(c31).Set(c32).Set(c33).Set(c34).Set(c35).Set(c36).Set(c37).Set(c38).Set(c39).Set(c40).Set(c41).Set(c42).Set(c43).Set(c44).Set(c45).Set(c46).Set(c47).Set(c48).Set(c49).Set(c50).Set(c51).Set(c52).Set(c53).Set(c54).Set(c55).Set(c56).Set(c57).Set(c58).Set(c59);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52, C53, C54, C55, C56, C57, C58, C59, C60>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26, C27 c27, C28 c28, C29 c29, C30 c30, C31 c31, C32 c32, C33 c33, C34 c34, C35 c35, C36 c36, C37 c37, C38 c38, C39 c39, C40 c40, C41 c41, C42 c42, C43 c43, C44 c44, C45 c45, C46 c46, C47 c47, C48 c48, C49 c49, C50 c50, C51 c51, C52 c52, C53 c53, C54 c54, C55 c55, C56 c56, C57 c57, C58 c58, C59 c59, C60 c60)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52, C53, C54, C55, C56, C57, C58, C59, C60>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26), typeof(C27), typeof(C28), typeof(C29), typeof(C30), typeof(C31), typeof(C32), typeof(C33), typeof(C34), typeof(C35), typeof(C36), typeof(C37), typeof(C38), typeof(C39), typeof(C40), typeof(C41), typeof(C42), typeof(C43), typeof(C44), typeof(C45), typeof(C46), typeof(C47), typeof(C48), typeof(C49), typeof(C50), typeof(C51), typeof(C52), typeof(C53), typeof(C54), typeof(C55), typeof(C56), typeof(C57), typeof(C58), typeof(C59), typeof(C60)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26).Set(c27).Set(c28).Set(c29).Set(c30).Set(c31).Set(c32).Set(c33).Set(c34).Set(c35).Set(c36).Set(c37).Set(c38).Set(c39).Set(c40).Set(c41).Set(c42).Set(c43).Set(c44).Set(c45).Set(c46).Set(c47).Set(c48).Set(c49).Set(c50).Set(c51).Set(c52).Set(c53).Set(c54).Set(c55).Set(c56).Set(c57).Set(c58).Set(c59).Set(c60);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52, C53, C54, C55, C56, C57, C58, C59, C60, C61>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26, C27 c27, C28 c28, C29 c29, C30 c30, C31 c31, C32 c32, C33 c33, C34 c34, C35 c35, C36 c36, C37 c37, C38 c38, C39 c39, C40 c40, C41 c41, C42 c42, C43 c43, C44 c44, C45 c45, C46 c46, C47 c47, C48 c48, C49 c49, C50 c50, C51 c51, C52 c52, C53 c53, C54 c54, C55 c55, C56 c56, C57 c57, C58 c58, C59 c59, C60 c60, C61 c61)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52, C53, C54, C55, C56, C57, C58, C59, C60, C61>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26), typeof(C27), typeof(C28), typeof(C29), typeof(C30), typeof(C31), typeof(C32), typeof(C33), typeof(C34), typeof(C35), typeof(C36), typeof(C37), typeof(C38), typeof(C39), typeof(C40), typeof(C41), typeof(C42), typeof(C43), typeof(C44), typeof(C45), typeof(C46), typeof(C47), typeof(C48), typeof(C49), typeof(C50), typeof(C51), typeof(C52), typeof(C53), typeof(C54), typeof(C55), typeof(C56), typeof(C57), typeof(C58), typeof(C59), typeof(C60), typeof(C61)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26).Set(c27).Set(c28).Set(c29).Set(c30).Set(c31).Set(c32).Set(c33).Set(c34).Set(c35).Set(c36).Set(c37).Set(c38).Set(c39).Set(c40).Set(c41).Set(c42).Set(c43).Set(c44).Set(c45).Set(c46).Set(c47).Set(c48).Set(c49).Set(c50).Set(c51).Set(c52).Set(c53).Set(c54).Set(c55).Set(c56).Set(c57).Set(c58).Set(c59).Set(c60).Set(c61);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52, C53, C54, C55, C56, C57, C58, C59, C60, C61, C62>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26, C27 c27, C28 c28, C29 c29, C30 c30, C31 c31, C32 c32, C33 c33, C34 c34, C35 c35, C36 c36, C37 c37, C38 c38, C39 c39, C40 c40, C41 c41, C42 c42, C43 c43, C44 c44, C45 c45, C46 c46, C47 c47, C48 c48, C49 c49, C50 c50, C51 c51, C52 c52, C53 c53, C54 c54, C55 c55, C56 c56, C57 c57, C58 c58, C59 c59, C60 c60, C61 c61, C62 c62)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52, C53, C54, C55, C56, C57, C58, C59, C60, C61, C62>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26), typeof(C27), typeof(C28), typeof(C29), typeof(C30), typeof(C31), typeof(C32), typeof(C33), typeof(C34), typeof(C35), typeof(C36), typeof(C37), typeof(C38), typeof(C39), typeof(C40), typeof(C41), typeof(C42), typeof(C43), typeof(C44), typeof(C45), typeof(C46), typeof(C47), typeof(C48), typeof(C49), typeof(C50), typeof(C51), typeof(C52), typeof(C53), typeof(C54), typeof(C55), typeof(C56), typeof(C57), typeof(C58), typeof(C59), typeof(C60), typeof(C61), typeof(C62)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26).Set(c27).Set(c28).Set(c29).Set(c30).Set(c31).Set(c32).Set(c33).Set(c34).Set(c35).Set(c36).Set(c37).Set(c38).Set(c39).Set(c40).Set(c41).Set(c42).Set(c43).Set(c44).Set(c45).Set(c46).Set(c47).Set(c48).Set(c49).Set(c50).Set(c51).Set(c52).Set(c53).Set(c54).Set(c55).Set(c56).Set(c57).Set(c58).Set(c59).Set(c60).Set(c61).Set(c62);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52, C53, C54, C55, C56, C57, C58, C59, C60, C61, C62, C63>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26, C27 c27, C28 c28, C29 c29, C30 c30, C31 c31, C32 c32, C33 c33, C34 c34, C35 c35, C36 c36, C37 c37, C38 c38, C39 c39, C40 c40, C41 c41, C42 c42, C43 c43, C44 c44, C45 c45, C46 c46, C47 c47, C48 c48, C49 c49, C50 c50, C51 c51, C52 c52, C53 c53, C54 c54, C55 c55, C56 c56, C57 c57, C58 c58, C59 c59, C60 c60, C61 c61, C62 c62, C63 c63)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52, C53, C54, C55, C56, C57, C58, C59, C60, C61, C62, C63>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26), typeof(C27), typeof(C28), typeof(C29), typeof(C30), typeof(C31), typeof(C32), typeof(C33), typeof(C34), typeof(C35), typeof(C36), typeof(C37), typeof(C38), typeof(C39), typeof(C40), typeof(C41), typeof(C42), typeof(C43), typeof(C44), typeof(C45), typeof(C46), typeof(C47), typeof(C48), typeof(C49), typeof(C50), typeof(C51), typeof(C52), typeof(C53), typeof(C54), typeof(C55), typeof(C56), typeof(C57), typeof(C58), typeof(C59), typeof(C60), typeof(C61), typeof(C62), typeof(C63)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26).Set(c27).Set(c28).Set(c29).Set(c30).Set(c31).Set(c32).Set(c33).Set(c34).Set(c35).Set(c36).Set(c37).Set(c38).Set(c39).Set(c40).Set(c41).Set(c42).Set(c43).Set(c44).Set(c45).Set(c46).Set(c47).Set(c48).Set(c49).Set(c50).Set(c51).Set(c52).Set(c53).Set(c54).Set(c55).Set(c56).Set(c57).Set(c58).Set(c59).Set(c60).Set(c61).Set(c62).Set(c63);
        }

        public static Entity Create<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52, C53, C54, C55, C56, C57, C58, C59, C60, C61, C62, C63, C64>(
        C1 c1, C2 c2, C3 c3, C4 c4, C5 c5, C6 c6, C7 c7, C8 c8, C9 c9, C10 c10, C11 c11, C12 c12, C13 c13, C14 c14, C15 c15, C16 c16, C17 c17, C18 c18, C19 c19, C20 c20, C21 c21, C22 c22, C23 c23, C24 c24, C25 c25, C26 c26, C27 c27, C28 c28, C29 c29, C30 c30, C31 c31, C32 c32, C33 c33, C34 c34, C35 c35, C36 c36, C37 c37, C38 c38, C39 c39, C40 c40, C41 c41, C42 c42, C43 c43, C44 c44, C45 c45, C46 c46, C47 c47, C48 c48, C49 c49, C50 c50, C51 c51, C52 c52, C53 c53, C54 c54, C55 c55, C56 c56, C57 c57, C58 c58, C59 c59, C60 c60, C61 c61, C62 c62, C63 c63, C64 c64)
        {
            ref var archetype = ref Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52, C53, C54, C55, C56, C57, C58, C59, C60, C61, C62, C63, C64>.archetype;
            if (!archetype) archetype = World.GetArchetype(new TypeSignature(typeof(C1), typeof(C2), typeof(C3), typeof(C4), typeof(C5), typeof(C6), typeof(C7), typeof(C8), typeof(C9), typeof(C10), typeof(C11), typeof(C12), typeof(C13), typeof(C14), typeof(C15), typeof(C16), typeof(C17), typeof(C18), typeof(C19), typeof(C20), typeof(C21), typeof(C22), typeof(C23), typeof(C24), typeof(C25), typeof(C26), typeof(C27), typeof(C28), typeof(C29), typeof(C30), typeof(C31), typeof(C32), typeof(C33), typeof(C34), typeof(C35), typeof(C36), typeof(C37), typeof(C38), typeof(C39), typeof(C40), typeof(C41), typeof(C42), typeof(C43), typeof(C44), typeof(C45), typeof(C46), typeof(C47), typeof(C48), typeof(C49), typeof(C50), typeof(C51), typeof(C52), typeof(C53), typeof(C54), typeof(C55), typeof(C56), typeof(C57), typeof(C58), typeof(C59), typeof(C60), typeof(C61), typeof(C62), typeof(C63), typeof(C64)));
            return archetype.CreateEntity().Set(c1).Set(c2).Set(c3).Set(c4).Set(c5).Set(c6).Set(c7).Set(c8).Set(c9).Set(c10).Set(c11).Set(c12).Set(c13).Set(c14).Set(c15).Set(c16).Set(c17).Set(c18).Set(c19).Set(c20).Set(c21).Set(c22).Set(c23).Set(c24).Set(c25).Set(c26).Set(c27).Set(c28).Set(c29).Set(c30).Set(c31).Set(c32).Set(c33).Set(c34).Set(c35).Set(c36).Set(c37).Set(c38).Set(c39).Set(c40).Set(c41).Set(c42).Set(c43).Set(c44).Set(c45).Set(c46).Set(c47).Set(c48).Set(c49).Set(c50).Set(c51).Set(c52).Set(c53).Set(c54).Set(c55).Set(c56).Set(c57).Set(c58).Set(c59).Set(c60).Set(c61).Set(c62).Set(c63).Set(c64);
        }

        class Sig { public static Archetype archetype = World.GetArchetype(new TypeSignature()); }
        class Sig<C1> { public static Archetype archetype; }
        class Sig<C1, C2> { public static Archetype archetype; }
        class Sig<C1, C2, C3> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52, C53> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52, C53, C54> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52, C53, C54, C55> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52, C53, C54, C55, C56> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52, C53, C54, C55, C56, C57> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52, C53, C54, C55, C56, C57, C58> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52, C53, C54, C55, C56, C57, C58, C59> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52, C53, C54, C55, C56, C57, C58, C59, C60> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52, C53, C54, C55, C56, C57, C58, C59, C60, C61> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52, C53, C54, C55, C56, C57, C58, C59, C60, C61, C62> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52, C53, C54, C55, C56, C57, C58, C59, C60, C61, C62, C63> { public static Archetype archetype; }
        class Sig<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20, C21, C22, C23, C24, C25, C26, C27, C28, C29, C30, C31, C32, C33, C34, C35, C36, C37, C38, C39, C40, C41, C42, C43, C44, C45, C46, C47, C48, C49, C50, C51, C52, C53, C54, C55, C56, C57, C58, C59, C60, C61, C62, C63, C64> { public static Archetype archetype; }
    }
}
