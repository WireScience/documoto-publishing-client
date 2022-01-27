# documoto-publishing-client

Example code, illustrating basic Documoto Publishing API operations.

## Configuration

The following environment variables are required for execution:
 
|enviroment variable | description | notes |
|--------------------|-------------|-------|
| DOCUMOTO_API_ENDPOINT | Services endpoint | SOAP 1.1 or 1.2, `https` required |
| DOCUMOTO_API_KEY | Tenant Encrypted Key (TEK) | Provided by Documoto |
| DOCUMOTO_SUPPLIER_CODE | Supplier Code | At least one must be defined in Documoto |
| DOCUMOTO_USER_NAME | Documoto User Name | Required for Creates and Updates. User must have sufficient permissions assigned (via Roles) |

*Note: the endpoints currently listed in the [WSDL](https://documoto.digabit.com/dws/services/PublishingService20?wsdl) are **incorrect**.
They include a port (`8080`) and specify `http`.*

### Launch Profiles

A Staging ("Integration" in Documoto) and Production launch profiles are provided.
Environment variables may be maintained therein, set on the machine, and/or provided via the Command Line.

## Connected Service

The following modifications were made to the initially generated client code:
- Added the relevant `using` statements, cleaned up (removed) associated fully-qualified references
- Added support for `https`
  - generated code did not include, because no `https` designation in published [Documoto WSDL](https://documoto.digabit.com/dws/services/PublishingService20?wsdl).
- Include both synchronous and asynchronous operations
- Removed explicit endpoints. Now must be provided via Configuration (see [above](##configuration)).