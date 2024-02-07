using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Universal_IdentifierType : INotifyPropertyChanged
	{
		private RoleObjectType person_ReferenceField;

		private Universal_Identifier_DataType[] universal_Identifier_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public RoleObjectType Person_Reference
		{
			get
			{
				return this.person_ReferenceField;
			}
			set
			{
				this.person_ReferenceField = value;
				this.RaisePropertyChanged("Person_Reference");
			}
		}

		[XmlElement("Universal_Identifier_Data", Order = 1)]
		public Universal_Identifier_DataType[] Universal_Identifier_Data
		{
			get
			{
				return this.universal_Identifier_DataField;
			}
			set
			{
				this.universal_Identifier_DataField = value;
				this.RaisePropertyChanged("Universal_Identifier_Data");
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
