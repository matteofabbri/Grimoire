using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Skill_Source_Precedence_DataType : INotifyPropertyChanged
	{
		private string precedence_OrderField;

		private Person_Skill_Source_CategoryObjectType[] skill_Source_Category_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Precedence_Order
		{
			get
			{
				return this.precedence_OrderField;
			}
			set
			{
				this.precedence_OrderField = value;
				this.RaisePropertyChanged("Precedence_Order");
			}
		}

		[XmlElement("Skill_Source_Category_Reference", Order = 1)]
		public Person_Skill_Source_CategoryObjectType[] Skill_Source_Category_Reference
		{
			get
			{
				return this.skill_Source_Category_ReferenceField;
			}
			set
			{
				this.skill_Source_Category_ReferenceField = value;
				this.RaisePropertyChanged("Skill_Source_Category_Reference");
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
