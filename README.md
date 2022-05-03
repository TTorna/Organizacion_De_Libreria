# Organizacion_De_Libreria

### Descripción del problema

Dimitri es un niño fanático de la literatura rusa. Hoy es su cumpleaños y sus familiares y amigos le obsequiaron N li-
bros de famosísimos autores rusos. Lleno de felicidad, Dimitri llevó todos sus libros hasta su cuarto, y para su sorpresa, le habían regalado también un nuevo librero. Notó que éste tenía bases de diversas alturas, y que en cada base cabía un solo libro. Había tantas bases como libros.
Al observar esto, Dimitri decidió que solo podría quedarse con los libros si era posible lograr que todos quedasen alineados a la misma altura. Es decir, una vez colocados (en algún orden) todos los libros tienen que coincidir en su parte superior. Los libros, al igual que las bases, vienen en varios tamaños, aunque solo nos interesa la altura.
Mientras Dimitri disfruta del resto de su día, tu tarea es determinar si existe un orden para colocar los libros, de tal forma que las alturas finales (libro + base) sean iguales.

### Detalles de implementación

Debes implementar la función librero (bases, libros), que dados los arreglos deenteros bases y libros (ambos de tamaño N), retorne la altura final resultante. En el caso de que no sea posible cumplir con el requisito solicitado de que todos los libros queden a una misma altura total en el librero, la función deberá retornar -1.

### Evaluador local

El evaluador local lee de la entrada estándar: Una primera línea con la cantidad de libros N Una segunda línea con N enteros, que representan las alturas de las distintas bases, en orden. Una tercera línea con N enteros, que representan las alturas de los distintos libros.

Devuelve por la salida estándar el resul- tado de llamar a la función librero.

Cotas *1 ≤ N ≤ 1000 *Todas las alturas son enteros entre 1 y 1000 inclusive.
