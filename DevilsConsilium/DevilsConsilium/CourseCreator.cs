using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevilsConsilium
{
    class CourseCreator
    {

        Courses cis105 = new Courses
            (
            "CIS105",
            "Computer Applications and Information Technology",
            "Introduces business information systems from a business intelligence perspective and the uses of " +
            "application software with emphasis on database and spreadsheet packages for efficient and effective problem solving.",
            3,
            false, false, true, false, false, false, false, false, false, false
            );

        Courses wpc101 = new Courses
            (
            "WPC101",
            "Student Success in Business",
            "Introduces students to resources that help them to succeed in the W. P. Carey School of Business.",
            1,
            false, false, false, false, false, false, false, false, false, false
            );

        Courses mat210 = new Courses
            (
            "MAT210",
            "Brief Calculus",
            "Differential and integral calculus of elementary functions with applications.",
            3,
            false, true, false, false, false, false, false, false ,false, false
            );

        Courses mat211 = new Courses
            (
            "MAT211",
            "Mathematics for Business Analysis",
            "Topics in business analysis, including: Lagrange multipliers, linear programming, linear algebra, " +
            "intermediate probability, random variables, discrete distributions, and continuous distributions.",
            3,
            false, false, false, false, false, false, false, false, false, false
            );

        Courses eng101 = new Courses
            (
            "ENG101",
            "First-Year Composition",
            "Discovers, organizes and develops ideas in relation to the writer's purpose, subject and audience. " +
            "Emphasizes modes of written discourse and effective use of rhetorical principles.",
            3,
            false, false, false, false, false, false, false, false, false, false
            );

        Courses eng102 = new Courses
            (
            "ENG102",
            "First-Year Composition",
            "Critical reading and writing; emphasizes strategies of academic discourse. Research paper required.",
            3,
            false, false, false, false, false, false, false, false, false, false
            );

        Courses soc101 = new Courses
            (
            "SOC101",
            "Introductory Sociology",
            "Fundamentals of sociology, organization of human groups and society, processes of interaction, and social change.",
            3,
            false, false, false, false, true, false, false, false, false, false
            );

        Courses psy101 = new Courses
            (
            "PSY101",
            "Introduction to Psychology",
            "Major areas of theory and research in psychology. Requires participation in department-sponsored research " +
            "or an educationally equivalent alternative activity.",
            3,
            false, false, false, false, true, false, false, false, false, false
            );

        Courses ala100 = new Courses
            (
            "ALA100",
            "Introduction to Environmental Design",
            "Surveys environmental design: includes historic examples and the theoretical, social, technical, and environmental forces that shape them.",
            3,
            false, false, false, true, false, false, false, false, true, true
            );

        Courses ecn211 = new Courses
            (
            "ECN211",
            "Macroeconomic Principles",
            "Basic macroeconomic analysis. Economic institutions and factors determining income levels, price levels, and employment levels.",
            3,
            false, false, false, false, true, false, false, false, false, false
            );

        Courses ecn212 = new Courses
            (
            "ECN212",
            "MicroEconomic Principles",
            "Basic microeconomic analysis. Theory of exchange and production, including the theory of the firm.",
            3,
            false, false, false, false, true, false, false, false, false, false
            );

        Courses com100 = new Courses
            (
            "COM100",
            "Introduction to Human Communication",
            "Topics-oriented introduction to basic theories, dimensions, and concepts of human communicative interaction and behavior.",
            3,
            false, false, false, false, true, false, false, false, false, false
            );

        Courses com225 = new Courses
            (
            "COM225",
            "Public Speaking",
            "Verbal and nonverbal communication in platform speaking. Discussion and practice in vocal and physical delivery and in purposeful " +
            "organization and development of public communication.",
            3,
            true, false, false, false, false, false, false, false, false, false
            );

        Courses com230 = new Courses
            (
            "COM230",
            "Small Group Communication",
            "Principles and processes of small group communication, attitudes, and skills for effective participation and leadership " +
            "in small groups, small group problem solving, and decision making.",
            3,
            false, false, false, false, true, false, false, false, false, false
            );

        Courses com259 = new Courses
            (
            "COM259",
            "Communication in Business and the Professions",
            "Interpersonal, group, and public communication in business and professional organizations.",
            3,
            false, false, false, false, false, false, false, false, false, false
            );

    }
}
