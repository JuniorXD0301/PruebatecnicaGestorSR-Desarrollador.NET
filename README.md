# PruebatecnicaGestorSR-Desarrollador.NET
Prueba técnica Gestor SR – Desarrollador .NET
## Arquitectura de la Solución (Basada en la Nube de Azure)
La solución propuesta se basará en una arquitectura de nube escalable para manejar la carga esperada de 500 usuarios diarios. Se utilizarán servicios de Azure para garantizar la eficiencia y la seguridad.
Componentes Principales:
1. Aplicación Móvil y Página Web:
   - Desarrolladas como aplicaciones separadas pero con una interfaz de usuario coherente basada en el manual de marca de la compañía.
   - Para la aplicación móvil, se puede considerar el desarrollo multiplataforma con tecnologías como Flutter.
2. Backend:
   - Este desarrollo se realiza utilizando Azure Functions, una solución que es flexible, modular y económica. Azure Functions es ideal para situaciones donde se anticipa una variabilidad en la carga de trabajo y se requiere una arquitectura basada en eventos y microservicios. Su capacidad para escalar automáticamente de acuerdo a la demanda y su modelo de precios basado en el uso, hacen de Azure Functions una opción robusta para este caso de uso.
   - API RESTful para la comunicación entre la aplicación y el backend. La elección de una API RESTful proporciona simplicidad, flexibilidad, escalabilidad y estándares abiertos, lo que la convierte en una opción sólida para facilitar la comunicación eficiente y efectiva entre la aplicación y el backend en el contexto del caso de prueba.
3. Base de Datos:
   - Azure SQL Database para almacenar la información de rutas, usuarios y suscripciones. Utilizar Azure SQL Database proporciona un entorno confiable, seguro y escalable para almacenar la información crítica de rutas, usuarios y suscripciones en el contexto del caso de prueba, y se alinea con las necesidades de rendimiento y seguridad de la aplicación.
4. Autenticación:
   - Azure Active Directory (Azure AD) para autenticar a los empleados de la compañía. Utilizar Azure Active Directory para autenticar a los empleados ofrece una solución integral que prioriza la seguridad, la eficiencia y la escalabilidad, lo cual es esencial para una aplicación empresarial que busca gestionar la autenticación de hasta 500 usuarios diarios.
5. Almacenamiento:
   - Azure Blob Storage para almacenar posiblemente imágenes o archivos relacionados con las rutas. El uso de Azure Blob Storage proporciona una solución robusta y escalable para almacenar imágenes y archivos relacionados con las rutas, garantizando un rendimiento eficiente, seguridad avanzada y flexibilidad de costos para el crecimiento futuro de la aplicación.
6. Notificaciones:
   - Azure Notification Hubs para gestionar notificaciones push a usuarios suscritos. Azure Notification Hubs es una solución integral para gestionar notificaciones push, brindando escalabilidad, flexibilidad y capacidades avanzadas de segmentación y análisis, lo que lo convierte en una elección sólida para la gestión eficiente de las notificaciones en la aplicación de publicación de rutas.
7. DevOps:
    - Azure DevOps es una herramienta integral que puede interactuar con casi todos los aspectos de la arquitectura. Puede ser el pegamento que une todos los componentes de la arquitectura, automatizando los procesos de integración y despliegue.
## Modelo Entidad-Relación
- Usuarios: ID, Nombre, Correo Electrónico, Rol (Conductor o Pasajero).
- Rutas: ID, Conductor (ID de Usuario), Origen, Destino, Cupos Disponibles, Hora de Salida, Hora de llegada.
- Suscripciones: ID de Usuario, ID de Ruta, Fecha de Suscripción.
- Roles: ID del rol, tipo de rol (Conductor o Pasajero).
- Usuario-Rol: ID del usuario, ID del rol.
## Tecnologías, Lenguajes de Programación y Frameworks
- Frontend: Angular para la página web, Flutter para la aplicación móvil.
- Backend: Node.js.
- Base de Datos: Azure SQL Database.
- Autenticación: Azure Active Directory.
- Notificaciones Push: Azure Notification Hubs.
- DevOps: Azure DevOps.
## Metodología de Desarrollo
Se recomienda el uso de metodologías ágiles, como Scrum, para facilitar la entrega iterativa de funcionalidades y la adaptación a cambios en los requisitos. Scrum se adapta bien a proyectos donde la flexibilidad, la entrega temprana y la adaptabilidad a cambios son fundamentales, como en el desarrollo de una aplicación de rutas de transporte.

## Buenas Prácticas Metodológicas
- Integración Continua (CI) y Despliegue Continuo (CD).
- Pruebas automatizadas.
- Code reviews regulares.
- Documentación clara y actualizada.

Infraestructura y Plataformas
- Despliegue usando Azure Functions para la aplicación web y móvil.
- Azure SQL Database para la base de datos.
- Azure Blob Storage para almacenamiento de archivos.
- Azure Active Directory para la gestión de identidades.
- Azure DevOps - Azure Functions: Azure DevOps puede automatizar el proceso de despliegue de las funciones a través de Azure Pipelines.
- Azure DevOps - Azure SQL Database: Para automatizar las migraciones de la base de datos.
- Azure DevOps - Azure Active Directory: Para manejar la autenticación durante el proceso de despliegue.
- Azure DevOps - Azure Blob Storage: Azure DevOps puede automatizar el despliegue de archivos a Azure Blob Storage.
- Azure DevOps - Azure Notification Hubs: Azure DevOps puede interactuar con Azure Notification Hubs para automatizar el proceso de envío de notificaciones.
- Azure DevOps - Angular: Azure DevOps puede construir y desplegar la aplicación Angular a través de Azure Pipelines.

## Posibles Riesgos y Mitigaciones
1. Riesgo: Problemas de rendimiento debido a un aumento repentino de usuarios.
   - Mitigación: Escalabilidad automática utilizando servicios de Azure.
2. Riesgo: Problemas de seguridad.
   - Mitigación: Auditoría de seguridad regular y seguimiento de las mejores prácticas de seguridad de Azure.
3. Riesgo: Cambios en los requisitos.
   - Mitigación: Uso de metodologías ágiles para adaptarse a cambios y comunicación constante con los interesados.

## Conclusión
La solución propuesta se basa en tecnologías de Azure para garantizar la escalabilidad, la eficiencia y la seguridad. La metodología ágil permite una entrega iterativa y rápida adaptación a cambios. La infraestructura en Azure proporciona la base necesaria para el desarrollo y la implementación exitosos.
