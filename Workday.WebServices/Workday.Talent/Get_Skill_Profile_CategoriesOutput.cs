using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Skill_Profile_CategoriesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Skill_Profile_Categories_ResponseType Get_Skill_Profile_Categories_Response;

		public Get_Skill_Profile_CategoriesOutput()
		{
		}

		public Get_Skill_Profile_CategoriesOutput(Get_Skill_Profile_Categories_ResponseType Get_Skill_Profile_Categories_Response)
		{
			this.Get_Skill_Profile_Categories_Response = Get_Skill_Profile_Categories_Response;
		}
	}
}
