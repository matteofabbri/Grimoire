using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Job_Profile_Union_Membership_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType requirement_Option_ReferenceField;

		private UnionObjectType[] union_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Requirement_Option_Reference
		{
			get
			{
				return this.requirement_Option_ReferenceField;
			}
			set
			{
				this.requirement_Option_ReferenceField = value;
				this.RaisePropertyChanged("Requirement_Option_Reference");
			}
		}

		[XmlElement("Union_Reference", Order = 1)]
		public UnionObjectType[] Union_Reference
		{
			get
			{
				return this.union_ReferenceField;
			}
			set
			{
				this.union_ReferenceField = value;
				this.RaisePropertyChanged("Union_Reference");
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
