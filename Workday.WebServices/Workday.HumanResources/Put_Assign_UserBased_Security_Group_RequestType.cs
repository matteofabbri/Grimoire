using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Put_Assign_User-Based_Security_Group_RequestType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Assign_UserBased_Security_Group_RequestType : INotifyPropertyChanged
	{
		private Assign_UserBased_Security_Group_DataType assign_UserBased_Security_Group_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Assign_User-Based_Security_Group_Data", Order = 0)]
		public Assign_UserBased_Security_Group_DataType Assign_UserBased_Security_Group_Data
		{
			get
			{
				return this.assign_UserBased_Security_Group_DataField;
			}
			set
			{
				this.assign_UserBased_Security_Group_DataField = value;
				this.RaisePropertyChanged("Assign_UserBased_Security_Group_Data");
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
