using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.WorkforcePlanning
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Headcount_Plan_Dimension_Management_DataType : INotifyPropertyChanged
	{
		private Worktag_and_Aggregation_TypeObjectType dimension_ReferenceField;

		private Headcount_Plan_Dimension_Restriction_DataType[] headcount_Plan_Dimension_Restriction_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Worktag_and_Aggregation_TypeObjectType Dimension_Reference
		{
			get
			{
				return this.dimension_ReferenceField;
			}
			set
			{
				this.dimension_ReferenceField = value;
				this.RaisePropertyChanged("Dimension_Reference");
			}
		}

		[XmlElement("Headcount_Plan_Dimension_Restriction_Data", Order = 1)]
		public Headcount_Plan_Dimension_Restriction_DataType[] Headcount_Plan_Dimension_Restriction_Data
		{
			get
			{
				return this.headcount_Plan_Dimension_Restriction_DataField;
			}
			set
			{
				this.headcount_Plan_Dimension_Restriction_DataField = value;
				this.RaisePropertyChanged("Headcount_Plan_Dimension_Restriction_Data");
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
