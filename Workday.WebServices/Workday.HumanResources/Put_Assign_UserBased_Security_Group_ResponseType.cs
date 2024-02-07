using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Put_Assign_User-Based_Security_Group_ResponseType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Assign_UserBased_Security_Group_ResponseType : INotifyPropertyChanged
	{
		private UserBased_Security_GroupObjectType userBased_Security_Group_ReferenceField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("User-Based_Security_Group_Reference", Order = 0)]
		public UserBased_Security_GroupObjectType UserBased_Security_Group_Reference
		{
			get
			{
				return this.userBased_Security_Group_ReferenceField;
			}
			set
			{
				this.userBased_Security_Group_ReferenceField = value;
				this.RaisePropertyChanged("UserBased_Security_Group_Reference");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
