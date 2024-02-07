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
	public class Disciplinary_Action_DataType : INotifyPropertyChanged
	{
		private Disciplinary_ActionObjectType disciplinary_Action_ReferenceField;

		private Disciplinary_Action_ReasonObjectType[] disciplinary_Action_Reason_ReferenceField;

		private Disciplinary_ActionObjectType[] disciplinary_Action_Related_To_ReferenceField;

		private Employee_Review_Details_DataType review_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Disciplinary_ActionObjectType Disciplinary_Action_Reference
		{
			get
			{
				return this.disciplinary_Action_ReferenceField;
			}
			set
			{
				this.disciplinary_Action_ReferenceField = value;
				this.RaisePropertyChanged("Disciplinary_Action_Reference");
			}
		}

		[XmlElement("Disciplinary_Action_Reason_Reference", Order = 1)]
		public Disciplinary_Action_ReasonObjectType[] Disciplinary_Action_Reason_Reference
		{
			get
			{
				return this.disciplinary_Action_Reason_ReferenceField;
			}
			set
			{
				this.disciplinary_Action_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Disciplinary_Action_Reason_Reference");
			}
		}

		[XmlElement("Disciplinary_Action_Related_To_Reference", Order = 2)]
		public Disciplinary_ActionObjectType[] Disciplinary_Action_Related_To_Reference
		{
			get
			{
				return this.disciplinary_Action_Related_To_ReferenceField;
			}
			set
			{
				this.disciplinary_Action_Related_To_ReferenceField = value;
				this.RaisePropertyChanged("Disciplinary_Action_Related_To_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Employee_Review_Details_DataType Review_Data
		{
			get
			{
				return this.review_DataField;
			}
			set
			{
				this.review_DataField = value;
				this.RaisePropertyChanged("Review_Data");
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
