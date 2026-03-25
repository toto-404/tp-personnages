## 1. Différence entre surcharge et redéfinition
- **Surcharge (overload)** : plusieurs méthodes dans la même classe avec le même nom mais des signatures différentes (types/nb d'arguments). Résolue à la compilation.  
- **Redéfinition (override)** : une méthode d'une classe dérivée remplace l’implémentation d’une méthode `virtual`/`abstract` de la classe de base (même signature). Résolue à l’exécution.

## 2. Pourquoi utiliser `virtual` et `override`
- `virtual` (ou `abstract`) dans la base : autorise la substitution par les classes dérivées.  
- `override` dans la dérivée : fournit l’implémentation spécifique.  
- Permet le comportement dynamique selon le type réel de l’objet.

## 3. Quel est l’intérêt du polymorphisme
- Traiter différents objets via une interface ou une classe de base commune tout en obtenant des comportements spécifiques à l’implémentation réelle.  
- Facilite l’extensibilité, la réutilisation et réduit les conditions basées sur les types dans le code.

## 4. Pourquoi le casting peut-il provoquer une erreur
- Un cast explicite `(Type)obj` suppose que l’objet est réellement de ce type ; sinon une `InvalidCastException` est levée à l’exécution.

## 5. Pourquoi vérifier le type avant un casting
- Pour éviter les exceptions et rendre le code robuste : utiliser `is` (pattern matching) ou `as` + `!= null` (ou `GetType()` si nécessaire) avant d’appeler des membres spécifiques.
